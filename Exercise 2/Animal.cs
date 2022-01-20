using System;

namespace Exercise_2
{
    abstract class Animal
    {
        public enum Type
        {
            mammal,
            bird
        }

        private Type type;

        protected Type Type1 { get => type; set => type = value; }

        protected Animal(Type type)
        {
            this.Type1 = type;
        }

        public abstract string Sound();

        public abstract string Info();

    }
}
