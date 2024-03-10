

//Console.WriteLine("Hello, World!");



//Console.WriteLine("===== RACE =====");


//Driver bob = new Driver("Bob", 7);
//Driver greg = new Driver("Greg", 3);
//Driver jill = new Driver("Jill", 5);
//Driver anne = new Driver("Anne", 9);

//Driver[] availableDrivers = { bob, greg, jill, anne };

//Console.WriteLine("Please choose your driver for the first car: (Bob/Greg/Jill/Anne)");
//string firstDriver = Console.ReadLine();
//Console.WriteLine("Please choose your driver for the second car: (Bob/Greg/Jill/Anne)");
//string secondDriver = Console.ReadLine();

//Driver? selectedFirstDriver = null;
//Driver? selectedSecondDriver = null;

//foreach (Driver driver in availableDrivers)
//{
//    if (firstDriver?.ToLower() == driver.Name.ToLower())
//    {
//        selectedFirstDriver = driver;
//    }
//    else
//    if (secondDriver?.ToLower() == driver.Name.ToLower())
//    {
//        selectedSecondDriver = driver;
//    }

//}
////////////////////////////////////////////////
////////////////////////////////////////////////

//Car hyundai = new Car("Hyundai", 3);
//Car mazda = new Car("Mazda", 5);
//Car ferrari = new Car("Ferrari", 6);
//Car porsche = new Car("Porsche", 9);

//Car[] availableCars = { hyundai, mazda, ferrari, porsche };

//Console.WriteLine("Please choose your car for the first car: (Hyundai/Mazda/Ferrari/Porsche)");
//string firstCarModel = Console.ReadLine();
//Console.WriteLine("Please choose your car for the second car: (Hyundai/Mazda/Ferrari/Porsche)");
//string secondCarModel = Console.ReadLine();

//Car? selectedFirstCar = null;
//Car? selectedSecondCar = null;

//foreach (Car car in availableCars)
//{
//    if (firstCarModel?.ToLower() == car.Model.ToLower())
//    {
//        selectedFirstCar = car;
//    }
//    else
//    if (secondCarModel?.ToLower() == car.Model.ToLower())
//    {
//        selectedSecondCar = car;
//    }
//}

////////////////////////////////////////////////
////////////////////////////////////////////////

//if (selectedFirstCar == null || selectedSecondCar == null || selectedFirstDriver == null || selectedSecondDriver == null)
//{
//    Console.WriteLine("You have selected invalid car or driver or duplicate car or driver!!");
//    return;
//}


//selectedFirstCar!.Driver = selectedFirstDriver;
//selectedSecondCar!.Driver = selectedSecondDriver;

//Car.RaceCars(selectedFirstCar, selectedSecondCar);
