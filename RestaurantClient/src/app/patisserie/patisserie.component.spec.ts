/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PatisserieComponent } from './patisserie.component';

describe('PatisserieComponent', () => {
  let component: PatisserieComponent;
  let fixture: ComponentFixture<PatisserieComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PatisserieComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PatisserieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
