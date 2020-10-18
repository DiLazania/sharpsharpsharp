using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class IDontLike
    {
        public string name;
        public override string ToString()
        {
            return "Why i did this? Because i can.";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            IDontLike person = (IDontLike)obj;
            return (this.name == person.name);
        }

        public override int GetHashCode()
        {
            Console.Write("Your HashCode, mr. Sergio: ");
            return name.GetHashCode();
        }
    }
}
