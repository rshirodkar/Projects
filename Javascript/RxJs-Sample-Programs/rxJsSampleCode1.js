// import necessary functions and operators from RxJS
import {Observable, Subscriber} from 'rxjs';
import {map, filter} from 'rxjs/operators';

// Function to simulate stock price updates
function simulateStockPrice(){
  // returns a stock price between 100 and 200
  return Math.floor(100 + Math.random() * 100);
}

// create an observable that emits a value every 1000 ms (1 sec)
const stockPriceObservable = new Observable(s => {
  const intervalId = setInterval(() => {
    const price = simulateStockPrice();
    s.next(price); // emits the simulated price
  }, 1000);

  // cleanup function when the subscription is unsubscribed
  return() => clearInterval(intervalId);
})


// using the map operator to convert the stock prise from USD to EUR (assuming the conversion rate)
const euroPrices = stockPriceObservable.pipe(map(price => price * 0.93));

// using the filter operator to emit only prices higher than 150 EUR
const filteredPrices = euroPrices.pipe(filter(price => price > 150));

// subscribe to the filtered euro prices and log them to the console
const subscription = filteredPrices.subscribe(price => console.log(`high stock price in EUR: ${price.toFixed(2)}`));

// stop the subscription after 10 seconds
setTimeout(() => {
  subscription.unsubscribe();
  console.log('stopped observing stock prices after 10 seconds');
}, 10000);