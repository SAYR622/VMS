using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Artifacts
    {

    }

    public class Artifact
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public int YearCreated { get; set; }
        public string Description { get; set; }

        public Artifact() { }

        public Artifact(int id, string title, string creator, int yearCreated, string description)
        {
            Id = id;
            Title = title;
            Creator = creator;
            YearCreated = yearCreated;
            Description = description;
        }
    }
}
