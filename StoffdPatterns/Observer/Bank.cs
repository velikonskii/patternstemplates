using System;

namespace StoffdPatterns.Observer {

    public class Bank : IObserver {
        
        public string Name { get; set; }
        private IObservable stock;

        public Bank(string name) {
            Name = name;
        }
        
        public void Update(StockInfo data) {
            var info = data;
            Console.WriteLine($"Bank работает с долларами по курсу {info.Euro}");
        }

        public void Unsubscribe() {
            stock.RemoveObserver(this);
            stock = null;
        }

        public void Subscribe(IObservable observable) {
            stock = observable;
            stock.RegisterObserver(this);
        }
    }
}