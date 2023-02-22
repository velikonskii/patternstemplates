using System.Collections.Generic;

namespace StoffdPatterns.Observer {
    
    public class Stock : IObservable {
        
        private StockInfo _stockInfo = new ();
        private List<IObserver> _observers = new ();

        public Stock() {}

        public void RegisterObserver(IObserver o) {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o) {
            _observers.Remove(o);
        }

        public void NotifyObservers() {
            foreach (var item in _observers) {
                item.Update(_stockInfo);
            }
        }

        public void Market() {
            _stockInfo.USD = 10;
            _stockInfo.Euro = 20;
            NotifyObservers();
        }
    }
}