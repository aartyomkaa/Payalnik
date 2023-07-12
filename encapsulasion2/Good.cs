using System;

namespace encapsulasion2
{
    public class Good
    {
        public Good(string name)
        {
            if (name == null)
                throw new ArgumentNullException();

            Name = name;
        }

        public string Name { get; private set; }
    }
}