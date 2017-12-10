import { Component, Input, Inject } from '@angular/core';

import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';

import { Trainer } from '../../models/trainer';

@Component({
  selector: 'app-trainer-delete-confirm-dialog',
  templateUrl: './trainer-delete-confirm-dialog.component.html',
  styleUrls: ['./trainer-delete-confirm-dialog.component.css']
})
export class TrainerDeleteConfirmDialogComponent {
  public constructor(
    public dialogRef: MatDialogRef<TrainerDeleteConfirmDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public trainer: Trainer) {
  }

  public onCloseConfirm(): void {
    this.dialogRef.close(this.trainer);
  }

  public onCloseCancel(): void {
    this.dialogRef.close(null);
  }
}
