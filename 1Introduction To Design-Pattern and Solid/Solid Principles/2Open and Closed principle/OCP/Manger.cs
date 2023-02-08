class Manger : Employee
{
    public override decimal CalcHourBouns(decimal hour)
    {
        return ((BasicSalary/30)/8)*hour*2;
    }
}