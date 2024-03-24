// See https://aka.ms/new-console-template for more information
using Factory_Pattern.Entities;
using Factory_Pattern.Enums;

Console.WriteLine("Hello, World!");

var factory = new AirConditioner().ExecuteCreation(Actions.Cooling, 22.5);
factory.Operate();
