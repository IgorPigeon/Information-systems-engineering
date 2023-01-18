class Program
{
    static void Main(string[] args)
    {
        var structure = new Bank();
        structure.Add(new Person { Name = "Igor", Surname = "Kazakevich", Number = "5392653" });
        structure.Add(new Company { Name = "Bunguie", RegNumber = "ewuir32141324", RegCountry = "USA" });
        structure.Accept(new HtmlVisitor());
        Console.WriteLine();
        structure.Accept(new XmlVisitor());

        Console.Read();
    }
}

interface IVisitor
{
    void VisitPersonAcc(Person acc);
    void VisitCompanyAc(Company acc);
}

class HtmlVisitor : IVisitor
{
    public void VisitPersonAcc(Person acc)
    {
        string result = "<table><tr><td>Properties<td><td>Value</td></tr>";
        result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
        result += "<tr><td>Surname<td><td>" + acc.Surname + "</td></tr>";
        result += "<tr><td>Number<td><td>" + acc.Number + "</td></tr></table>";
        Console.WriteLine(result);
    }

    public void VisitCompanyAc(Company acc)
    {
        string result = "<table><tr><td>Properties<td><td>Value</td></tr>";
        result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
        result += "<tr><td>Registration Number<td><td>" + acc.RegNumber + "</td></tr>";
        result += "<tr><td>Registration Country<td><td>" + acc.RegCountry + "</td></tr></table>";
        Console.WriteLine(result);
    }
}

class XmlVisitor : IVisitor
{
    public void VisitPersonAcc(Person acc)
    {
        string result = "<Person><Name>" + acc.Name + "</Name>" + "<Surname>" + acc.Surname + "</Surname>" +
            "<Number>" + acc.Number + "</Number><Person>";
        Console.WriteLine(result);
    }

    public void VisitCompanyAc(Company acc)
    {
        string result = "<Company><Name>" + acc.Name + "</Name>" +
            "<RegNumber>" + acc.RegNumber + "</RegNumber>" +
            "<RegCountry>" + acc.RegCountry + "</RegCountry><Company>";
        Console.WriteLine(result);
    }
}

class Bank
{
    List<IAccount> accounts = new List<IAccount>();
    public void Add(IAccount acc)
    {
        accounts.Add(acc);
    }
    public void Remove(IAccount acc)
    {
        accounts.Remove(acc);
    }
    public void Accept(IVisitor visitor)
    {
        foreach (IAccount acc in accounts)
            acc.Accept(visitor);
    }
}

interface IAccount
{
    void Accept(IVisitor visitor);
}

class Person : IAccount
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Number { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitPersonAcc(this);
    }
}

class Company : IAccount
{
    public string Name { get; set; }
    public string RegNumber { get; set; }
    public string RegCountry { get; set; }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitCompanyAc(this);
    }
}