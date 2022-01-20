
namespace Exercise_2
{
    class Cat : Animal
    {
        public enum Climb
        {
            tree, wall, roof, etc
        }

        private Climb climb;

        public Cat(Type type) : base(type)
        {
        }

        public Cat(Climb climb1, Type type) : base(type)
        {
            Climb1 = climb1;
        }

        internal Climb Climb1 { get => climb; set => climb = value; }


        public override string Info() => $"Climb {Climb1} cat. Type {base.Type1}";

        public override string Sound() => "Meo Meo";
    }
}
