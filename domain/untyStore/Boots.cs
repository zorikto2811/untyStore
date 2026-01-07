using System;

namespace untyStore
{
    public class Boots
    {
        public int Id { get; }

        public string Title { get; }

        public Boots(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
