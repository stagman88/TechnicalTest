import { Injectable, Inject, Optional } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { publishReplay, refCount } from 'rxjs/operators';

import { environment } from '../../environments/environment';
import { Client } from '../models/client';

@Injectable()
export class ClientsService {
  protected apiBaseUrl: string;

  constructor(protected http: HttpClient) {
    this.apiBaseUrl = environment.apiUri;
  }

  public fetchTotalClientsCount(): Observable<number> {
    return this.http.get<number>(this.apiBaseUrl + "/clients/totalclientscount");
  }

  public fetchAllClients(): Observable<Client[]> {
    return this.http.get<Client[]>(this.apiBaseUrl + "/clients/allclients");
  }

}


