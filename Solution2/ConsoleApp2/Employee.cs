namespace ConsoleApp6;

public class Employee
{
    private string name;
    private string surname;
    private double experience;
    private string post; 

    public string Name { get; set; }
    public string Surname { get; set; }
    public double Experience { get; set; }
    public string Post { get; set; } 
    
    public Employee(string name, string surname, double experience, string post)
    {
        Name = name;
        Surname = surname;
        Experience = experience;
        Post = post;
    }
    
    // public (double, double) SalaryAndTax(double experience, string post)
    // {
    //     (double, double) salarytax;
    //     if (experience < 1 | post == "jun")
    //     {
    //         salarytax = (500, 0);
    //     }
    //     
    //     else if (experience < 3 & experience >= 1 & (post == "mid" | post == "sen"))
    //     {
    //         salarytax = (1000, 150);
    //     }
    //     
    //     else
    //     {
    //         salarytax = (0, 0);  
    //     }
    //
    //     return salarytax;
    // }
    
    public EmployeeFinance CalculateEmployeeFinance(double experience, string post)
    {
        var finance = new EmployeeFinance();
        if (experience < 1 | post == "jun")
        {
            finance.Salary = 500;
            finance.Tax = 0;
        }
        
        else if (experience < 3 & experience >= 1 & (post == "mid" | post == "sen"))
        {
            finance.Salary = 1000;
            finance.Tax = 150;
        }
        
        else
        {
            finance.Salary = 0;
            finance.Tax = 0;  
        }

        return finance;
    }

    public void ShowEmployee()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Surname);
        Console.WriteLine(Post);
        Console.WriteLine(Experience);
        var finance = CalculateEmployeeFinance(experience, post);
        Console.WriteLine($"Salary = {finance.Salary}");
        Console.WriteLine($"Tax = {finance.Tax}");
    }
}