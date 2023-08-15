// See https://aka.ms/new-console-template for more information
using BuilderPractice;
using BuilderPractice.HouseExample;
using BuilderPractice.VehicleExample;

Console.WriteLine("Hello, World!");

VehicleBuilder builder;
VehicleDirector director = new VehicleDirector();

builder = new CarBuilder();
director.Construct(builder);
builder.Vehicle.Show();

builder = new MotorCycleBuilder();
director.Construct(builder);
builder.Vehicle.Show();

Console.WriteLine("----------");
IHouseBuilder houseBuilder = new HouseBuilder();
HouseDirector houseDirector = new HouseDirector(houseBuilder);

houseDirector.MakeBasicHouse();
houseDirector.ShowInfo();
houseDirector.MakePremiumHouse();
houseDirector.ShowInfo();




// Wait for user
Console.ReadKey();