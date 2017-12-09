import { Component, OnInit } from '@angular/core';

import { Trainer } from '../../models/trainer';

import { TrainersService } from '../../services/trainers.service';

@Component({
  selector: 'app-add-trainer',
  templateUrl: './add-trainer.component.html',
  styleUrls: ['./add-trainer.component.css'],
  providers: [TrainersService]
})
export class AddTrainerComponent implements OnInit {

  public trainer: Trainer;

  public constructor(private trainersService: TrainersService) { }

  public ngOnInit() {
    this.trainer = new Trainer();
  }

  public onSubmit() {
    this.trainersService.add(this.trainer)
      .subscribe((response) => console.log(response));
  }
}
