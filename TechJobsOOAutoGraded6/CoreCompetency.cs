using System;
namespace TechJobsOOAutoGraded6
{
	public class CoreCompetency 
	{
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }

        // TODO: Task 2: Change the fields to auto-implemented properties.
        //Changed id and value fields to properties Id and Value with get and set methods to allow the properties to be accessed and modified.
        //Access modifiers were also changed from private to public to allow access from other classes and objects
        //Removed constructors and replaced with one that inherits from JobField.

        public CoreCompetency() 
        {
            Id = nextId++;
            nextId++;
        }

        public CoreCompetency(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

