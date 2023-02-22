using System;

namespace StoffdPatterns.Adapter {
    public class AdapterExecute {
        public void Execute() {
            Driver driver = new Driver();
            Auto auto = new Auto();
            driver.Travel(auto);
            Camel camel = new Camel();
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            driver.Travel(camelTransport);

        }

    }

    public class Auto : ITransport {
        public void Drive() {
            Console.WriteLine("Машина едет по дороге");
        }
    }

    public class Driver {
        public void Travel(ITransport transport) {
            transport.Drive();
        }
    }
}