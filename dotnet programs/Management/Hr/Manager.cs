using Hr;
namespace staff;

public class Manager:Employee{

    private double salary;
    private double incentives;
    //constructor
    public Manager() { }
    public Manager(int salary,int incentives,string fname,string lname,string email,int age)
        :base(fname,lname,email,age) {
        this.salary = salary;
        this.incentives = incentives;

    }

    //getter setter
    // public int Salary{
    //     get { return salary; }
    //     set { salary = value; }
    // }

    // public int incentives
    // {
    //     get { return incentives; }
    //     set { incentives = value; }
    // }

    public double ComputeSalary(){
        return this.salary+this.incentives;
    }
    
}