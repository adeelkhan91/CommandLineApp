import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Router } from '@angular/router';
@Component({
  selector: 'app-confirm-dialog',
  templateUrl: './confirm-dialog.component.html',
  styleUrls: ['./confirm-dialog.component.scss'],
})
export class ConfirmDialogComponent {
  title: string;
  message: string;
  constructor(
    public dialogRef: MatDialogRef<ConfirmDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: ConfirmDialogModel,
    private router: Router
  ) {
    this.title = 'Confirm';
    this.message = data.message;
  }

  signOut(): void {

    this.dialogRef.close();
  }

  close(): void {
    this.dialogRef.close();
  }
}

export class ConfirmDialogModel {
  constructor(public title: string, public message: string) {}
}
