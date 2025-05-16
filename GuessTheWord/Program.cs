using System;
using System.Collections.Generic;

namespace GuessTheWord
{
    public class Program
    {
        private readonly IDictionary<string, string> dictionary;
        private readonly Controller controller;
        private readonly View view;
        private readonly Model model;

        public static void Main()
        {

            View view = new View();
            Model model = new Model();
            Controller controller = new Controller(view, model);
            controller.Run();
        }
    }
}
