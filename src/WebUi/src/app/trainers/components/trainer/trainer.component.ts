import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { Trainer } from '../../models/trainer';

import { TrainersService } from '../../services/trainers.service';

@Component({
  selector: 'app-trainer',
  templateUrl: './trainer.component.html',
  styleUrls: ['./trainer.component.css'],
  providers: [TrainersService]
})

export class TrainerComponent implements OnInit {

  private isEdit: boolean;

  public trainer: Trainer;
  public submitBtnTxt: string;

  public constructor(
    private trainersService: TrainersService,
    private route: ActivatedRoute) { }

  public ngOnInit() {
    this._initTrainer();
  }

  public onSubmit() {
    if (this.isEdit) {
      this.trainersService.edit(this.trainer)
        .subscribe((response) => console.log(response));
    } else {
      this.trainersService.add(this.trainer)
        .subscribe((response) => console.log(response));
    }
  }

  private _initTrainer(): void {
    const id = +this.route.snapshot.paramMap.get('id');

    if (id) {
      this.isEdit = true;
      this.trainersService.get(id)
        .subscribe((trainer) => this.trainer = trainer);

    } else {
      this.isEdit = false;
      this.trainer = new Trainer();
    }

    this.initSubmitBtnTxt();
  }

  private initSubmitBtnTxt(): void {
    this.submitBtnTxt = this.isEdit ? 'Edit' : 'Add';
  }

}
