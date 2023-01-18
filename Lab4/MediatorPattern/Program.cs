using MediatorPattern;

ManagerMediator mediator = new ManagerMediator();
Colleague customer = new CustomerColleague(mediator);
Colleague programmer = new ProgrammerColleague(mediator);
Colleague tester = new TesterColleague(mediator);
mediator.Customer = customer;
mediator.Programmer = programmer;
mediator.Tester = tester;
customer.Send("An order, need to make a program");
programmer.Send("The program is ready, need to test it");
tester.Send("The program is tested and ready for sale");

Console.Read();