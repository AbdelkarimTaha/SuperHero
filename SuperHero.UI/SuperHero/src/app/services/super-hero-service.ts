import { environment } from './../../environments/environment';
import { Observable } from 'rxjs/internal/Observable';
import { SuperHero } from './../models/super-hero';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SuperHeroService {
  private url = "SuperHero";
  constructor(private http: HttpClient) { }

  public getSuperHeroes(): Observable<SuperHero[]>{
    return this.http.get<SuperHero[]>(`${environment.apiUrl}/${this.url}`);
  }
}
