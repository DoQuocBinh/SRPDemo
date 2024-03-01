using System;
namespace Solution1
{
	class Student
	{

	}
	class Lecturer
	{
		Student student;
        public void TakeAttendence()
		{
			//do something with student data
		}
	}

	class EmployeeSaver
	{
		public void SaveEmployee(EmployeeData employeeData)
		{
			//saving data to the database for example
		}
	}
	class EmployeeData
	{
	}
	class PayCalculator
	{
		public void CalculatePay(EmployeeData employeeData)
		{
			//calculate salary for example based on employeeData
		}
	}
	class CFO
	{
		public void DoSomeThing()
		{
			EmployeeData data = new EmployeeData();
			PayCalculator payCalculator = new PayCalculator();
			payCalculator.CalculatePay(data);
		}
	}
	class HourReporter
	{
		public void ReportHour(EmployeeData employeeData)
		{

		}
	}
	class COO
	{
        public void DoSomeThing()
        {
            EmployeeData data = new EmployeeData();
            HourReporter hourReporter = new HourReporter();
            hourReporter.ReportHour(data);

        }
    }
}

