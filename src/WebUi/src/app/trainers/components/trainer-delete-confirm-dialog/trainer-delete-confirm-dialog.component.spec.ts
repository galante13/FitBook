import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TrainerDeleteConfirmDialogComponent } from './trainer-delete-confirm-dialog.component';

describe('TrainerDeleteConfirmDialogComponent', () => {
  let component: TrainerDeleteConfirmDialogComponent;
  let fixture: ComponentFixture<TrainerDeleteConfirmDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TrainerDeleteConfirmDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TrainerDeleteConfirmDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
