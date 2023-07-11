namespace Hr;

public class Employee
{
    private string fname;
    private string lname;
    private string email;
    private int age;

    public Employee(){}
    public Employee(string fname,string lname,string email,int age){
        this.fname=fname;
        this.lname=lname;
        this.email=email;
        this.age=age;
    }

    public override string ToString(){
        return fname + " " + lname + " " + email+" "+age ;
    }
}
