import { Component } from '@angular/core';

@Component({
    selector: 'stock',
    templateUrl: './stock.component.html'
})
export class StockComponent {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount++;
    }
}
