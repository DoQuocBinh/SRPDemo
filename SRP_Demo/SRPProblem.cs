using System;
namespace SRP_Problem
{
	class Employee
	{
		public void CalculatePay()
		{
		}
		public void ReportHour()
		{

		}
		public void Save()
		{

		}
	}
	class CFO
	{
		public void DoSomething()
		{
			Employee emp = new Employee();
			emp.CalculatePay();
			emp.ReportHour(); //=>bad design: CFO not work with ReportHour
			emp.Save();//=>bad design: CFO not work with Save
        }
	}
}

