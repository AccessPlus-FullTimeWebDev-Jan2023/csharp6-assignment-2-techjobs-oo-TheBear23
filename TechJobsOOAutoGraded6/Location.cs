using System;
namespace TechJobsOOAutoGraded6
{
	public class Location 
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }


        // TODO: Task 2: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.

        //Access modifier is public so it can be accessed from other classes
        //': this() calls the default constructor prior to executing its own code  (Removed!) (Readded!!)
        //The default constructor is called to initialize the Id property - Reason for this is to ensure that Locattion obnject is initialized with a unique ID value. This is due to the ID being used to distinguish one location from another
        //The Value property is set using value of value parameter passed to the constructor - Value property was set with the value parameter to allow the caller to specify the location value during object initialization.
        //*This constructor allows Location objects to be created with a specified location value while still ensuring that each object has a unique ID.
 
        public Location()
        {
            Id = nextId;
            nextId++;
        }

        public Location(string value) : this()
        {
            Value = value;
        }
        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
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

