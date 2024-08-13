using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.AllMethods
{
    public class Teacher
    {
        internal static void Delete(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagementSystem;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Teachers where TeacherId=@TeacherId";

                cmd.Parameters.AddWithValue("@TeacherId", id);

                int data=cmd.ExecuteNonQuery();
                if(data >0)
                {
                    Console.WriteLine("delete");
                }

                con.Close();    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static void Edit(int id, AddTeacher teach)
        {
           //create connection
           SqlConnection conn = new SqlConnection();    
            //save databse entries
            conn.ConnectionString= @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagementSystem;Integrated Security=True";
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Teachers set Name=@Name,Qualification=@Qualification,Experience=@Experience,Age=@Age,Instructor=@Instructor,AadharNumber=@AadharNumber,AccountNumber=@AccountNumber,Address=@Address,PanNumber=@PanNumber,Email=@Email,MobileNumber=@MobileNumber where TeacherId=@TeacherId";

                //update all parameters
                cmd.Parameters.AddWithValue("@Name",teach.Name);
                cmd.Parameters.AddWithValue("@Qualification", teach.Qualification);
                cmd.Parameters.AddWithValue("@Experience",teach.Experience);
                cmd.Parameters.AddWithValue("@Age", teach.Age);
                cmd.Parameters.AddWithValue("@Instructor",teach.Instructor);
                cmd.Parameters.AddWithValue("@AadharNumber",teach.Aadhar);
                cmd.Parameters.AddWithValue("@AccountNumber",teach.AccountNumber);
                cmd.Parameters.AddWithValue("@Address",teach.Address);
                cmd.Parameters.AddWithValue("@PanNumber",teach.PanNo);
                cmd.Parameters.AddWithValue("@Email",teach.Email);
                cmd.Parameters.AddWithValue("@MobileNumber",teach.MobileNo);

                cmd.Parameters.AddWithValue("@TeacherId", id);

                int data = cmd.ExecuteNonQuery();
                if(data > 0)
                {
                    Console.WriteLine("Update SuccessFull....");
                }


                    conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        internal static List<AddTeacher> GetAllTeacher()
        {
            List<AddTeacher> teacher=new List<AddTeacher>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagementSystem;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType =CommandType.Text;
                cmd.CommandText = "select * from Teachers";

                using (SqlDataReader reader=cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        AddTeacher teach = new AddTeacher();

                        teach.TeacherId = reader.GetInt32(0);
                        teach.Name = reader.GetString(1);
                        teach.Qualification = reader.GetString(2);
                        teach.Experience= reader.GetInt32(3);
                        teach.Age= reader.GetInt32(4);
                        teach.Instructor=reader.GetString(5);
                        teach.Aadhar=reader.GetString(6);
                        teach.AccountNumber = reader.GetString(7);
                        teach.Address=reader.GetString(8);
                        teach.PanNo=reader.GetString(9);
                        teach.Email= reader.GetString(10);
                        teach.MobileNo=reader.GetString(11);

                        //data add into the list collection
                        teacher.Add(teach);
                    }
                   
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return teacher;
        }

        internal static AddTeacher GetSingleTeacher(int id)
        {
            AddTeacher teach = new AddTeacher();

            SqlConnection con=new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagementSystem;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand cmd=con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Teachers where TeacherId=@TeacherId";

                cmd.Parameters.AddWithValue("@TeacherId", id);

                using (SqlDataReader reader=cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        teach.TeacherId = reader.GetInt32(0);
                        teach.Name = reader.GetString(1);
                        teach.Qualification = reader.GetString(2);
                        teach.Experience = reader.GetInt32(3);
                        teach.Age = reader.GetInt32(4);
                        teach.Instructor = reader.GetString(5);
                        teach.Aadhar = reader.GetString(6);
                        teach.AccountNumber = reader.GetString(7);
                        teach.Address = reader.GetString(8);
                        teach.PanNo = reader.GetString(9);
                        teach.Email = reader.GetString(10);
                        teach.MobileNo = reader.GetString(11);
                    }
                }


                    con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return teach;
        }

        internal static void Insert(AddTeacher teach)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString= @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagementSystem;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand cmd=con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Teachers values(@TeacherId,@Name,@Qualification,@Experience,@Age,@Instructor,@AadharNumber,@AccountNumber,@Address,@PanNumber,@Email,@MobileNumber)";

                cmd.Parameters.AddWithValue("@TeacherId",teach.TeacherId);
                cmd.Parameters.AddWithValue("@Name", teach.Name);
                cmd.Parameters.AddWithValue("@Qualification",teach.Qualification);
                cmd.Parameters.AddWithValue("@Experience",teach.Experience);
                cmd.Parameters.AddWithValue("@Age",teach.Age);
                cmd.Parameters.AddWithValue("@Instructor",teach.Instructor);
                cmd.Parameters.AddWithValue("@AadharNumber",teach.Aadhar);
                cmd.Parameters.AddWithValue("@AccountNumber", teach.AccountNumber);
                cmd.Parameters.AddWithValue("@Address", teach.Address);
                cmd.Parameters.AddWithValue("@PanNumber",teach.PanNo);
                cmd.Parameters.AddWithValue("@Email",teach.Email);
                cmd.Parameters.AddWithValue("@MobileNumber", teach.MobileNo);


                cmd.ExecuteNonQuery();
              

                con.Close() ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}