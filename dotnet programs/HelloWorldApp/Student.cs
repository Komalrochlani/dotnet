using Hr;
namespace LMS;


public class Student:Person{

    private int rollNo;
    private  string course;
    private DateTime registrationDate;

    public Student(){}
    public Student(int r,string c,DateTime regDate,string fname,string lname,string contactNo,int age, DateTime date)
        :base(fname,lname,contactNo, age,date)      
    {
        this.rollNo = r;
        this.course=c;
        this.registrationDate=regDate;

    }

    public override string ToString(){
        string data=base.ToString();

        return data + " "+ this.rollNo +" " +this.course +" " +this.registrationDate; 
    }
}