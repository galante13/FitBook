import { Component, OnInit } from '@angular/core';

import { MatTableDataSource } from '@angular/material';

import { TrainersService } from '../../services/trainers.service';
import { Trainer } from '../../models/trainer';

@Component({
  selector: 'app-trainers-list',
  templateUrl: './trainers-list.component.html',
  styleUrls: ['./trainers-list.component.css'],
  providers: [TrainersService]
})
export class TrainersListComponent implements OnInit {

  private displayedColumns = ['id', 'name', 'birthDate', 'birthCity', 'nationality', 'bio', 'city', 'actions'];
  private dataSource: MatTableDataSource<Trainer>;

  public constructor(private trainersService: TrainersService) { }

  public ngOnInit() {
    this._initTrainers();
  }

  public applyFilter(filterValue: string) {
    filterValue = filterValue.trim();
    filterValue = filterValue.toLowerCase();
    this.dataSource.filter = filterValue;
  }

  public editTrainer(trainer: Trainer): void {

  }

  public deleteTrainer(trainer: Trainer): void {

  }

  private _initTrainers(): void {
    this.trainersService.getAll()
      .subscribe((trainers) => this.dataSource = new MatTableDataSource(trainers));
  }

}
