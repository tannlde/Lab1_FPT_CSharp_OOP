
namespace Exercise_2
{
    class Duck : Animal
    {
        public enum Swim
        {
            pond, pool, etc
        }

        private Swim swim;

        public Duck(Type type) : base(type)
        {
        }

        public Duck(Swim swim1, Type type) : base(type)
        {
            Swim1 = swim1;
        }

        internal Swim Swim1 { get => swim; set => swim = value; }

        public override string Info() => $"The duck is swim in {Swim1}";

        public override string Sound() => "Vit vit";
    }
}
