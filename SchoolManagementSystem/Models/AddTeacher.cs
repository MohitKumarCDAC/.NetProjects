using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models
{
    public class AddTeacher
    {
        //private static int count = 0;
        private int teacherid;
        private string name;
        private string qualification;
        private int experience;
        private int age;
        private string instructor;
        private string aadhar;
        private string accountNo;
        private string pannumber;
        private string address;
        private string email;
        private string mobileno;

        //properties

        public int TeacherId
        {
            get { return teacherid; }
            set { teacherid = value; }
        }
        public string Name
        {

            get { return name; }
            set { name = value; }
        }

        public string Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Aadhar
        {
            get { return aadhar; }
            set {  aadhar = value; }
            
        }
        public string PanNo
        {
            get { return pannumber; }
            set {  pannumber = value; }
            
        }
        public string MobileNo
        {
            get { return mobileno; }
            set {
               mobileno = value;
            }
            
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string AccountNumber
        {
            get { return accountNo; }
            set { accountNo = value; }
        }

        public AddTeacher()
        {

        }
        public AddTeacher(int teacherid,string name, string qualification, int experience, int age, string instructor, string aadhar, string accountNo, string pannumber, string address, string email, string mobileno)
        {
            TeacherId = teacherid;
            Name = name;
            Qualification = qualification;
            Experience = experience;
            Age = age;
            Instructor = instructor;
            Aadhar = aadhar;
            AccountNumber = accountNo;
            Email = email;
            PanNo = pannumber;
            MobileNo = mobileno;
            Aadhar = aadhar;
        }
        public override string ToString()
        {
            return $"ID:{TeacherId},TeacherName:{Name},Qualification:{Qualification},Experience:{Experience},Age:{Age},Instructor:{Instructor},AccountNumber:{accountNo},PanNumber:{PanNo},Address:{Address},AadharNumber:{Aadhar},PhoneNumber:{MobileNo},EmailID:{Email}";
        }

    }
}