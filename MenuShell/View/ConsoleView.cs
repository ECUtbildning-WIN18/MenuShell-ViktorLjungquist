using System;

namespace Menushell.View
{
    abstract class ConsoleView
    {
        public string Id { get; }
        public string Title { get; }

        protected ConsoleView(string id, string title)
        {
            Id = id;

            Console.Title = title;
        }
    }
}
