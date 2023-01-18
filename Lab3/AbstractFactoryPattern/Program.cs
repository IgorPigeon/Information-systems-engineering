using AbstractFactoryPattern;
using System;

IAbstractFactory factory_1 = new ConcreteFactory_1();
var productA1 = factory_1.CreateProductA();
var productB1 = factory_1.CreateProductB();

Console.WriteLine(productA1.GetName());
Console.WriteLine(productB1.GetName());
Console.WriteLine("\n");

IAbstractFactory factory_2 = new ConcreteFactory_2();
var productA_2 = factory_2.CreateProductA();
var productB_2 = factory_2.CreateProductB();

Console.WriteLine(productA_2.GetName());
Console.WriteLine(productB_2.GetName());