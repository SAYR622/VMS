using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Guides
    {
    }

    public class Guide
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public bool IsAvailable { get; set; }

        public Guide() { }

        public Guide(int id, string name, string specialization, bool isAvailable)
        {
            Id = id;
            Name = name;
            Specialization = specialization;
            IsAvailable = isAvailable;
        }
    }
}
