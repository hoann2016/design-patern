﻿namespace Abstract_Factory
{
    #region Abs factory declearation
    abstract class Herbivore
    {
    }
    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
    #endregion

    #region Object method implementation
    class Wildebeest : Herbivore
    {
    }
    class Bison : Herbivore
    {
    }
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest

            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison

            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    #endregion

    #region Create class based in Factory = bind object
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
    #endregion


    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        // Constructor

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}