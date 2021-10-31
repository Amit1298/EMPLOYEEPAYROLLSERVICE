using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EMPLOYEEpAYROLLsERVICE
{
    class EmployeeRepo
    {
        public static string connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=payroll_services;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void GetAllEmployee()
        {
            try
            {
                EmployeeModal employeeModal = new EmployeeModal();
                using (this.connection)
                {
                    string query = @"Select employee_id,employee_name,Employee_age,Employee_address,employee_genderemployee_salary,ModifiedDate from Employee";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            employeeModal.Eemployee_id = dr.GetInt32(0);
                            employeeModal.employee_name = dr.GetString(1);
                            employeeModal.Employee_age = dr.GetInt32(2);
                            employeeModal.Employee_address = dr.GetString(3);
                            employeeModal.employee_gender = dr.GetString(4);
                            employeeModal.employee_salary = dr.GetInt32(5);
                            employeeModal.ModifiedDate = dr.GetDateTime(6);

                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{}",employeeModal.Eemployee_id,employeeModal.employee_name,employeeModal.Employee_age,employeeModal.Employee_address,employeeModal.employee_gender,employeeModal.employee_salary,employeeModal.ModifiedDate);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    dr.Close();
                    this.connection.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
