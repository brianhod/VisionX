import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public orderBook: OrderBook = {} as OrderBook;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<OrderBook>(baseUrl + 'GetOrderBook').subscribe(result => {
      this.orderBook = result;
    }, error => console.error(error));
  }
}

export interface Ask {
  side: string;
  quantity: string;
  price: string;
  currencyPair: string;
  orderCount: number;
}

export interface Bid {
  side: string;
  quantity: string;
  price: string;
  currencyPair: string;
  orderCount: number;
}

export interface OrderBook {
  asks: Ask[];
  bids: Bid[];
  lastChange: string;
  sequenceNumber: number;
}
