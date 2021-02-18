import { Component } from '@angular/core';
import { Client } from '../models/client';
import { ClientSalesProfit } from '../models/clientsalesprofit';
import { Product } from '../models/product';
import { ClientsService } from '../services/clients';
import { SalesReportingService } from '../services/salesreporting';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {

  public clients: ClientSalesProfit[];
  public mostIncome: ClientSalesProfit;

  public leastProfit: ClientSalesProfit;
  public mostProfit: ClientSalesProfit;
  public mostOrders: ClientSalesProfit;
  public mostProfitableProduct: Product; //The most profitable product

  public colours: string[] = [
    '#F343AC',
    '#E98064',
    '#F5C564',
    '#8D61FE',
    '#6AA3F2',
    '#91D6F4',
    '#3DD293',
    '#BDEF29'
  ];

  constructor(private salesReportingService: SalesReportingService, private clientService: ClientsService) {

  }

  public ngOnInit(): void {
    this.salesReportingService.fetchClientSalesProfit().subscribe(c => {
      this.clients = c;

      this.clients.forEach((client) => {
        if (!this.mostIncome || client.totalSalesIncome > this.mostIncome.totalSalesIncome) {
          this.mostIncome = client;
        }
      });
    });

  }

}
