using BuilderPattern;
using System;

var director = new Director();
var concreteBuilder = new ConcreteBuilder();
director.Builder = concreteBuilder;

Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(concreteBuilder.GetResult().ListParts());

Console.WriteLine("Standard full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(concreteBuilder.GetResult().ListParts());
