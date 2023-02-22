using System;

namespace StoffdPatterns.Observer {
    public class Broker : IObserver {

        public string Name { get; set; }
        private IObservable stock;

        public Broker(string name) {
            Name = name;
        }

        public void Update(StockInfo data) {
            var info = data;
            Console.WriteLine($"Брокер работает с долларами по курсу {info.USD}");
        }

        public void Subscribe(IObservable observable) {
            stock = observable;
            stock.RegisterObserver(this);
        }

        public void Unsubscribe() {
            stock.RemoveObserver(this);
            stock = null;
        }
    }


}