using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models
{
    public class StudentAdmission
    {
        //private static int count = 0;
        private int id;
        private string name;
        private string fathername;
        private string mothername;
        private string address;
        private DateTime dob;
        private string aadhar;
        private string mobileno;
        private string email;
        private string program;


        //properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Fathername
        {
            get { return fathername; }
            set { fathername = value; }
        }
        public string Mothername
        {
            get { return mothername; }
            set { mothername = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        
        public string Aadhar
        {
            get { return aadhar; }
            set { aadhar = value; }
        }
        public string MobileNo
        {
            get { return mobileno; }
            set { mobileno = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        public StudentAdmission()
        {

        }

        //constructor
        public StudentAdmission(int id,string name, string fathername, string mothername, string address, DateTime dob, string aadhar, string mobileno, string email, string program)
        {
            Id = id;
            Name = name;
            Fathername = fathername;
            Mothername = mothername;
            Address = address;
            Dob = dob;
            Aadhar = aadhar;
            MobileNo = mobileno;
            Email = email;
            Program = program;
        }

        //tostring method override
        public override string ToString()
        {
            return $"ID:{id},StudentName:{Name},FatherName:{Fathername},MotherName:{Mothername},Address:{Address},DateOfBirth:{Dob},AadharNumber:{Aadhar},PhoneNumber:{MobileNo},EmailID:{Email},Program:{Program}";
        }
    }
}