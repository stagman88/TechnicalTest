
import { Injectable, Inject, Optional } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { publishReplay, refCount } from 'rxjs/operators';

import { environment } from '../../environments/environment';

import { ClientSalesProfit } from '../models/clientsalesprofit';

@Injectable()
export class SalesReportingService {
  protected apiBaseUrl: string;

  constructor(protected http: HttpClient) {
    this.apiBaseUrl = environment.apiUri;
  }

  public fetchTotalSales(): Observable<number> {
    return this.http.get<number>(this.apiBaseUrl + "/salesreporting/totalsales");
  }

  public fetchTotalSalesByProductId(productId: number): Observable<number> {
    return this.http.get<number>(this.apiBaseUrl + "/salesreporting/totalsalesbyproduct?productId=" + productId);
  }


  public fetchTotalSalesByClientId(clientId: number): Observable<number> {
    return this.http.get<number>(this.apiBaseUrl + "/salesreporting/totalsalesbyclient?clientId=" + clientId);
  }

  public fetchClientSalesProfit(): Observable<ClientSalesProfit[]> {
    return this.http.get<ClientSalesProfit[]>(this.apiBaseUrl + "/salesreporting/clientsalesprofit");
  }

}
