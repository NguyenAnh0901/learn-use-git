using System;

namespace learn_use_git
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public People(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
