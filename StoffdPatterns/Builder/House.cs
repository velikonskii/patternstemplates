using System;
using System.Collections;
using System.Collections.Generic;

namespace StoffdPatterns.Builder {
    public class House {
        public string GardenType;
        public int Number { get; set; }
        public List<string> Walls { get; } = new List<string>();
        public string DoorType { get; set; }
        public bool HasGarden { get; set; }
        public bool HasFence { get; set; }
        public List<int> Floors { get; } = new List<int>();


        public void HouseShow() {

            foreach (var item in Floors) {
                Console.WriteLine($"floor number {item} was built");
            }

            foreach (var item in Walls) {
                Console.WriteLine($"side {item} was built");
            }
            Console.WriteLine($"{DoorType} door was built");

            if (HasGarden) {
                Console.WriteLine($"Garden: {GardenType} ");
            }

            if (HasFence) {
                Console.WriteLine("Fence was Created");
            }


        }

    }
}