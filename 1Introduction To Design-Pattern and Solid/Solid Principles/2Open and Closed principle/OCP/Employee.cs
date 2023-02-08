 

    // before OCP
            //public abstract class Employee{ 
            // public string ID{get;set;}
            // public string name{get;set;}
            // public decimal BasicSalary{set;get;}
            // public string EmployeeType{set;get;}


            // public decimal CalcHourBouns(decimal hour){
            //     return ((BasicSalary/30)/8)*hour;
            // }

            // public string ToString(){
            //     return $"Employee Id :{ID} ,name :{name}";
            // }}


       // After OCP

   abstract class Employee{

    public string name;
    public string id;
    public decimal BasicSalary;
    public string Employeetype;

    public abstract decimal CalcHourBouns(decimal hour);

    public string ToString(){
        return $"Employee id :{id} ,name {name}";
    }

   }
