import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { TrainersListComponent } from './trainers/components/trainers-list/trainers-list.component';
import { TrainerComponent } from './trainers/components/trainer/trainer.component';

const routes: Routes = [
  { path: 'trainers', component: TrainersListComponent },
  { path: 'trainer/:id', component: TrainerComponent }
  { path: 'trainer', component: TrainerComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
