using System;
using Restaurant.controllers;

namespace Restaurant
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RowController rowController = new RowController();
            rowController.rowProcessor();
        }
    }
}