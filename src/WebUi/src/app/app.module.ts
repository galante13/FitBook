import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { HttpClientModule, HttpHeaders } from '@angular/common/http';

import 'hammerjs';

import { FormsModule } from '@angular/forms';

import {
  MatInputModule, MatButtonModule, MatFormFieldModule,
  MatNativeDateModule, MatDatepickerModule,
  MatIconModule, MatCardModule, MatSidenavModule,
  MatListModule, MatTableModule, MatDialogModule
} from '@angular/material';

import {
  DateAdapter
} from '@angular/material';

import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { SidenavComponent } from './sidenav/sidenav.component';

import { TrainerComponent } from './trainers/components/trainer/trainer.component';
import { TrainersListComponent } from './trainers/components/trainers-list/trainers-list.component';
import {
  TrainerDeleteConfirmDialogComponent
} from './trainers/components/trainer-delete-confirm-dialog/trainer-delete-confirm-dialog.component';

import { FitbookDateAdapter } from './utils/fitbook-date-adapter';

import { AppRoutingModule } from './/app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    TrainerComponent,
    SidenavComponent,
    TrainersListComponent,
    TrainerComponent,
    TrainerDeleteConfirmDialogComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,

    FormsModule,

    MatInputModule,
    MatButtonModule,
    MatFormFieldModule,
    MatNativeDateModule,
    MatDatepickerModule,
    MatIconModule,
    MatCardModule,
    MatSidenavModule,
    MatListModule,
    MatTableModule,
    MatDialogModule,

    HttpClientModule,

    AppRoutingModule
  ],
  entryComponents: [
    TrainerDeleteConfirmDialogComponent
  ],
  providers: [
    { provide: DateAdapter, useClass: FitbookDateAdapter }],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }
