using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Trainers.Api.Model;
using Trainers.Api.Model.Abstract;
using Trainers.Api.ViewModels;

namespace Trainers.Api.Controllers
{
    //TODO: Change verbs Put for edit and post for add
    //also change it in Angular app.
    //change route, add api versioning
    [Route("api/[controller]")]
    public class TrainersController : Controller
    {
        private readonly IRepository<Trainer> _trainerRepository;
        private readonly IMapper _mapper;

        public TrainersController(
            IRepository<Trainer> trainerRepository,
            IMapper mapper)
        {
            _trainerRepository = trainerRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var trainers = _trainerRepository.Query().ToArray();

            var trainersViewModels = _mapper.Map<TrainerViewModel[]>(trainers);

            return Ok(trainersViewModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _trainerRepository.GetAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<TrainerViewModel>(entity);
            return Ok(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromBody]TrainerViewModel trainerViewModel)
        {
            var contextEntry = await _trainerRepository.GetAsync(trainerViewModel.Id);

            if (contextEntry == null)
            {
                return BadRequest();
            }

            _mapper.Map(trainerViewModel, contextEntry);
            await _trainerRepository.EditAsync(contextEntry);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Add([FromBody]TrainerViewModel trainerViewModel)
        {
            var entity = _mapper.Map<Trainer>(trainerViewModel);
            await _trainerRepository.AddAsync(entity);

            return Ok();
            //TODO
            //return Created();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _trainerRepository.DeleteAsync(id);

            return Ok();
        }
    }
}
