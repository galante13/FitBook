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
  MatListModule
} from '@angular/material';

import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { AddTrainerComponent } from './trainers/components/add-trainer/add-trainer.component';
import { SidenavComponent } from './sidenav/sidenav.component';


@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    AddTrainerComponent,
    SidenavComponent,
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

    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ]
})
export class AppModule { }
