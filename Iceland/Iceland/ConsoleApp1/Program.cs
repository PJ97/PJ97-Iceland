using ConsoleApp1.Classes;
using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            var items = new List<Item>() {
                new FlourishingItem("Aged Brie", 1, 1, false),
                new FlourishingItem("Christmas Crackers", -1, 2, true),
                new FlourishingItem("Christmas Crackers", 9, 2, true),
                new Item("Soap", 2, 2),
                new DecayingItem("Frozen Item", -1, 55, true),
                new DecayingItem("Frozen Item", 2, 2, true),
                new DecayingItem("Invalid Item", 2, 2, false),
                new DecayingItem("Fresh Item", 2, 2, false),
                new DecayingItem("Fresh Item", -1, 5, false)
            };

            foreach (Item i in items) {
                Console.WriteLine($"Day 1: {i.Display}");
                if (i is IAgingItem) (i as IAgingItem).AgeItem();
                Console.WriteLine($"Day 2: {i.Display}\n");
            }

            Console.WriteLine("In the end, I found when the rules were applied to the data set passed into them, the resulting output didn't match up with the expected output." +
                "\nFrozen Item One has 55 days which is invalid. Being frozen, the quality is going to only go down by one multiplied by the fact it is past sell by." +
                "\nThis results in 53. Even if it wasn't frozen, it would have been a drop in quality by 4 and ended up at 51 which is still invalid.");
            Console.ReadLine();
        }
    }
}
