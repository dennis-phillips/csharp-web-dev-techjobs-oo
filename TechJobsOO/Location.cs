using System;
namespace TechJobsOO
{
    public class Location : JobField
    {
        

        

        public Location(string value) : base(value)
        {
            
        }

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.

        

        public override string ToString()
        {
            return Value;
        }
    }
}
