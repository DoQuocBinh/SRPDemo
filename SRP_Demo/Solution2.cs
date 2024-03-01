using System;
namespace SRP_Solution2
{
	class EmployeeData //storing Employee information. name, salary, workhours....
	{
	}
	class PayCalculator //only used by CFO actor
	{
		public void CalculatePay(EmployeeData employeeData)
		{
			//do real calculating for employee's salary
		}
	}
	class HourReporter
	{
		public void ReportHour(EmployeeData employeeData)
		{
			//report employee's work hour; do real work here!
		}
	}
	class EmployeeFacade
	{
		public void CalculatePay(EmployeeData employeeData)
		{
			PayCalculator payCalculator = new PayCalculator();
			payCalculator.CalculatePay(employeeData);
		}
		public void ReportHour(EmployeeData employeeData)
		{
			HourReporter hourReporter = new HourReporter();
			hourReporter.ReportHour(employeeData);
		}
	}
	class CFO
	{
		public void TestCalculatePay(EmployeeData employeeData)
		{
			EmployeeFacade facade = new EmployeeFacade();
			facade.CalculatePay(employeeData);
		}
	}

}

