using System;
namespace TechJobsOOAutoGraded6
{
	public class PositionType 
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId++;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType positionType &&
                   Id == positionType.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
        // TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.
    }
}



/*The Equals() method overrides the default implementation of the method inherited from the Object class. It takes an object parameter (obj) and returns a boolean value indicating whether the current PositionType object is equal to the specified object.

The implementation checks if the specified object is a PositionType object (using the is keyword), and if so, it casts the object to a PositionType object and assigns it to the variable positionType.
It then compares the Id property of the current PositionType object with the Id property of the positionType object. If they are equal, the method returns true, indicating that the two objects are considered equal. Otherwise, it returns false.
The GetHashCode() method overrides the default implementation of the method inherited from the Object class. It returns an integer value that represents the hash code of the current PositionType object.

The implementation uses the static HashCode.Combine() method to combine the hash codes of the Id property. This method generates a hash code that is unique to the combination of the specified values. Since the Id property is guaranteed to be unique for each PositionType object, this implementation ensures that each object has a unique hash code.
The ToString() method overrides the default implementation of the method inherited from the Object class. It returns a string representation of the current PositionType object.

The implementation returns the value of the Value property of the object, which is the name or description of the position type.
Summary: The Equals() method checks the type of the object being compared before performing the comparison, the GetHashCode() method generates a hash code that is unique to the object's properties, and the ToString() method provides a meaningful string representation of the object.*/



























































