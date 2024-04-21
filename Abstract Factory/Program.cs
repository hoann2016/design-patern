using Abstract_Factory;

// Create and run the African animal world
ContinentFactory africa = new AfricaFactory();
AnimalWorld world = new AnimalWorld(africa);
world.RunFoodChain();

// Create and run the American animal world
ContinentFactory america = new AmericaFactory();
world = new AnimalWorld(america);
world.RunFoodChain();

//Lion eats Wildebeest
// Wolf eats Bison
Console.ReadKey();