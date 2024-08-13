using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebGrease.ImageAssemble;

namespace SchoolManagementSystem.AllMethods
{
    public class Student
    {
        internal static void DeleteStudent(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagementSystem;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand cmd=con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Student where Id=@Id";

                cmd.Parameters.AddWithValue("@Id",id);
                int data=cmd.ExecuteNonQuery();
                if(data > 0)
                {
                    Console.WriteLine("delete Data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static void Edit(int id, StudentAdmission std)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagementSystem;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Student set StudentName=@StudentName,FatherName=@FatherName,MotherName=@MotherName,Address=@Address,DateOfBirth=@DateOfBirth,AadharNumber=@AadharNumber,MobileNumber=@MobileNumber,EmailId=@EmailId,Program=@Program where id=@Id";

                
                cmd.Parameters.AddWithValue("@StudentName",std.Name);
                cmd.Parameters.AddWithValue("@FatherName",std.Fathername);
                cmd.Parameters.AddWithValue("@MotherName",std.Mothername);
                cmd.Parameters.AddWithValue("@Address",std.Address);
                cmd.Parameters.AddWithValue("@DateOfBirth",std.Dob);
                cmd.Parameters.AddWithValue("@AadharNumber", std.Aadhar);
                cmd.Parameters.AddWithValue("@MobileNumber", std.MobileNo);
                cmd.Parameters.AddWithValue("@EmailId", std.Email);
                cmd.Parameters.AddWithValue("@Program", std.Program);
                cmd.Parameters.AddWithValue("@Id",id);
                //execute the update query
                int readData=cmd.ExecuteNonQuery();
                if (readData > 0)
                {
                    Console.WriteLine("Update Successfull");
                }
                con.Close();      
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal static List<StudentAdmission> GetAllStudent()
        {
            List<StudentAdmission> studentAdmissionList=new List<StudentAdmission>();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagementSystem;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType=CommandType.Text;
                cmd.CommandText = "select * from Student";
                using (SqlDataReader reader=cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StudentAdmission admission = new StudentAdmission();
                        admission.Id = reader.GetInt32(0);
                        admission.Name = reader.GetString(1);
                        admission.Fathername = reader.GetString(2);
                        admission.Mothername = reader.GetString(3);
                        admission.Address = reader.GetString(4);
                        admission.Dob = (DateTime)reader.GetSqlDateTime(5);
                        admission.Aadhar=reader.GetString(6);
                        admission.MobileNo = reader.GetString(7);
                        admission.Email = reader.GetString(8);
                        admission.Program = reader.GetString(9);
                        studentAdmissionList.Add(admission);
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return studentAdmissionList;
        }

        internal static StudentAdmission GetSingleStudent(int id)
        {
            StudentAdmission admission = new StudentAdmission();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagementSystem;Integrated Security=True";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType=CommandType.Text;
                cmd.CommandText = "select * from Student where id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader=cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        admission.Id = reader.GetInt32(0);
                        admission.Name = reader.GetString(1);
                        admission.Fathername = reader.GetString(2);
                        admission.Mothername = reader.GetString(3);
                        admission.Address = reader.GetString(4);
                        admission.Dob = (DateTime)reader.GetSqlDateTime(5);
                        admission.Aadhar = reader.GetString(6);
                        admission.MobileNo = reader.GetString(7);
                        admission.Email = reader.GetString(8);
                        admission.Program = reader.GetString(9);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return admission;
        }

        internal static void Insert(StudentAdmission std)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagementSystem;Integrated Security=True";
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Student values(@Id,@StudentName,@FatherName,@MotherName,@Address,@DateOfBirth,@AadharNumber,@MobileNumber,@EmailId,@Program)";

                cmd.Parameters.AddWithValue("@Id", std.Id);
                cmd.Parameters.AddWithValue("@StudentName", std.Name);
                cmd.Parameters.AddWithValue("@FatherName", std.Fathername);
                cmd.Parameters.AddWithValue("@MotherName", std.Mothername);
                cmd.Parameters.AddWithValue("@Address", std.Address);
                cmd.Parameters.AddWithValue("@DateOfBirth", std.Dob);
                cmd.Parameters.AddWithValue("@AadharNumber", std.Aadhar);
                cmd.Parameters.AddWithValue("@MobileNumber", std.MobileNo);
                cmd.Parameters.AddWithValue("@EmailId", std.Email);
                cmd.Parameters.AddWithValue("@Program", std.Program);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
                {
                con.Close();
            }

        }

        static void Connect()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentManagementSystem;Integrated Security=True";
            try
            {
                cn.Open();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }
    }
}