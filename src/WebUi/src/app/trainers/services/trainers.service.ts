import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs/Observable';

import { Trainer } from '../models/trainer';

import { AppSettings } from '../../core/AppSettings';

@Injectable()
export class TrainersService {
  private readonly urlPrefix = AppSettings.API_ENDPOINT + '/api/trainers';

  public constructor(private http: HttpClient) { }

  public add(trainer: Trainer): Observable<any> {
    return this.http.put(this.urlPrefix, trainer);
  }

  public edit(trainer: Trainer): Observable<any> {
    return this.http.post(this.urlPrefix, trainer);
  }

  public getAll(): Observable<Trainer[]> {
    return this.http.get<Trainer[]>(this.urlPrefix);
  }

  public get(id): Observable<Trainer> {
    return this.http.get<Trainer>(this.urlPrefix + `/${id}`);
  }

  public delete(id): Observable<any> {
    return this.http.delete(this.urlPrefix + `/${id}`);
  }

}
