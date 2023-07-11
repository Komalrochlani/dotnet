namespace Hr;

public class Person{

    private  string firstName;
    private string lastName;
    private string contactNo;
    private int age;
    private DateTime dob;


    //property syntax
    public string FirstName{
        get{return this.firstName;}
        set{this.firstName=value;}
    }

    //constructor overloading
    public Person(){}
    public Person(string fname,string lname,string contactNo,int age, DateTime date){

        this.firstName=fname;
        this.lastName=lname;
        this.contactNo=contactNo;
        this.age=age;
        this.dob=date;
    }

    public override string ToString(){
        string data = base.ToString();
        return data + " "+ this.firstName+" "+ this.lastName+" "+this.contactNo+" "+this.age+" "+this.dob;
    }


}