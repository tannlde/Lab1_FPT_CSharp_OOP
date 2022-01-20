
namespace Exercise_2
{
    class Dog : Animal
    {
        public enum Breed
        {
            Spaniel,
            Chihuahua,
            Collie
        }

        private Breed breed;

        public Dog(Breed breed, Type type) : base(type)
        {
            this.Breed1 = breed;
        }

        internal Breed Breed1 { get => breed; set => breed = value; }

        public Dog(Type type) : base(type)
        {
        }

        public override string Info() => $"{Breed1} dog. Type {base.Type1}";

        public override string Sound() => "Cho cho";
    }
}
