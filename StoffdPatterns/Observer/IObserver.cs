using System;

namespace StoffdPatterns.Observer {
    public interface IObserver {
        void Update(StockInfo data);
        void Unsubscribe();
        public void Subscribe(IObservable observable);
    }
}