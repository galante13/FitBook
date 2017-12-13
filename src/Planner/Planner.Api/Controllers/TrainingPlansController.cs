using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Planner.Api.Model;
using Planner.Api.Model.Abstract;
using Planner.Api.ViewModels;

namespace Planner.Api.Controllers
{
    [Route("v1/[controller]")]
    public class TrainingPlansController : Controller
    {
        private readonly IRepository<TrainingPlan> _trainingPlanRepository;
        private readonly IMapper _mapper;

        public TrainingPlansController(
            IRepository<TrainingPlan> trainingPlanRepository,
            IMapper mapper)
        {
            _trainingPlanRepository = trainingPlanRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var plans = _trainingPlanRepository.Query().ToArray();

            var viewModels = _mapper.Map<TrainingPlanViewModel[]>(plans);

            return Ok(viewModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _trainingPlanRepository.GetAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<TrainingPlanViewModel>(entity);
            return Ok(viewModel);
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody]TrainingPlanViewModel viewModel)
        {
            var contextEntry = await _trainingPlanRepository.GetAsync(viewModel.Id);

            if (contextEntry == null)
            {
                return BadRequest();
            }

            _mapper.Map(viewModel, contextEntry);
            await _trainingPlanRepository.EditAsync(contextEntry);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]TrainingPlanViewModel viewModel)
        {
            var entity = _mapper.Map<TrainingPlan>(viewModel);
            await _trainingPlanRepository.AddAsync(entity);

            return Ok();
            //TODO
            //return Created();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _trainingPlanRepository.DeleteAsync(id);

            return Ok();
        }

    }
}