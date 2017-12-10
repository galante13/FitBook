import { Component, OnInit } from '@angular/core';

import { MatTableDataSource, MatDialog } from '@angular/material';

import { Router } from '@angular/router';

import { TrainersService } from '../../services/trainers.service';
import { Trainer } from '../../models/trainer';

import { TrainerDeleteConfirmDialogComponent } from '../trainer-delete-confirm-dialog/trainer-delete-confirm-dialog.component';

@Component({
  selector: 'app-trainers-list',
  templateUrl: './trainers-list.component.html',
  styleUrls: ['./trainers-list.component.css'],
  providers: [TrainersService]
})
export class TrainersListComponent implements OnInit {

  private displayedColumns = ['id', 'name', 'birthDate', 'birthCity', 'nationality', 'bio', 'city', 'actions'];
  private dataSource: MatTableDataSource<Trainer>;

  public constructor(
    private trainersService: TrainersService,
    private router: Router,
    public confirmDeleteTrainerDialog: MatDialog) { }

  public ngOnInit() {
    this._initTrainers();
  }

  public applyFilter(filterValue: string) {
    filterValue = filterValue.trim();
    filterValue = filterValue.toLowerCase();
    this.dataSource.filter = filterValue;
  }

  public editTrainer(trainer: Trainer): void {
    this.router.navigate(['/trainer', trainer.id]);
  }

  public openDeleteTrainerConfirm(trainer: Trainer): void {
    const dialogRef = this.confirmDeleteTrainerDialog.open(TrainerDeleteConfirmDialogComponent, {
      data: { trainer: trainer }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result && result.trainer) {
        this.trainersService.delete(result.trainer.id)
          .subscribe(() => {
            this._initTrainers();
          }
          );
      }
    });
  }

  private _initTrainers(): void {
    this.trainersService.getAll()
      .subscribe((trainers) => this.dataSource = new MatTableDataSource(trainers));
  }

}
