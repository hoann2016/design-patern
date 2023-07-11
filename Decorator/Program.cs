﻿using Decorator;

ICar objCar = new EconomyCar();

//Wrap EconomyCar instancw with BasicAccessories.   
CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);

//Wrap EconomyCar instance with AdvancedAccessories instance.   
objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
Console.WriteLine("\n\n");
Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

Console.Read();