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
  MatListModule, MatTableModule
} from '@angular/material';

import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { TrainerComponent } from './trainers/components/trainer/trainer.component';
import { SidenavComponent } from './sidenav/sidenav.component';
import { TrainersListComponent } from './trainers/components/trainers-list/trainers-list.component';

import { AppRoutingModule } from './/app-routing.module';


@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    TrainerComponent,
    SidenavComponent,
    TrainersListComponent,
    TrainerComponent,
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

    HttpClientModule,

    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class AppModule { }
