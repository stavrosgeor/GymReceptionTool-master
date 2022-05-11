using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;


namespace GymReceptionTool
{
    class DataAccess
    {
        /////////////////
        ///User BLOCK////
        /////////////////
        public List<User> GetUser(string Username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<User>($"SELECT * FROM Users WHERE Username ='" + Username + "'").ToList();
                return output;
            }
        }
        public string GetUserName(string ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<User>($"SELECT * FROM Users WHERE ID ='" + ID + "'").ToList();
                return output[0].Name;
            }
        }
        public List<User> GetUserbyID(string ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<User>($"SELECT * FROM Users WHERE ID ='" + ID + "'").ToList();
                return output;
            }
        }
        public List<User> GetUserbyTel(string TelNo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<User>($"SELECT * FROM Users WHERE Tel ='" + TelNo + "'").ToList();
                return output;
            }
        }


        public void InsertUser(User user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"INSERT INTO Users (Name,Tel,Address,Username,Password,DateAdded) VALUES ('" + user.Name + "','" + user.Tel + "','" + user.Address + "','" + user.Username + "','" + user.Password + "','" + user.DateAdded + "')");
            }
        }

        public void UpdateUser(User user) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"UPDATE Users SET Name = '"+ user.Name + "',Tel='"+ user.Tel + "',Address='"+user.Address+"',Username='"+user.Username+"',Password='"+ user.Password+ "' WHERE (ID='"+user.ID+"')");

            }
        }

        public void DeleteUser(User user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"DELETE FROM Users WHERE ID='" + user.ID + "'");
            }
        }

        ////////////////////////
        ///END OF User BLOCK////
        ////////////////////////

        ///////////////////////
        ///Instructor BLOCK////
        ///////////////////////

        public List<Instructor> GetInstructors()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Instructor>($"SELECT * FROM Instructors").ToList();
                return output;
            }
        }

        public List<Instructor> GetInstrbyID(string ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Instructor>($"SELECT * FROM Instructors WHERE ID ='" + ID + "'").ToList();
                return output;
            }
        }

        public string GetInstactorName(string ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Instructor>($"SELECT * FROM Instructors WHERE ID ='" + ID + "'").ToList();
                return output[0].Name + " "+ output[0].Surname;
            }
        }
        public List<Instructor> GetInstrbyTel(string TelNo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Instructor>($"SELECT * FROM Instructors WHERE Tel ='" + TelNo + "'").ToList();
                return output;
            }
        }


        public void InsertInstr(Instructor instructor)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"INSERT INTO Instructors (Name,Surname,email,UserRegistered,Tel,Address) VALUES ('" + instructor.Name + 
                    "','" + instructor.Surname + "','" + instructor.email + "','" + instructor.UserRegistered + "','" + instructor.Tel + "','" + instructor.Address+"')");
            }
        }

        public void UpdateInstr(Instructor instructor)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"UPDATE Instructors SET Name = '" + instructor.Name + "',Surname = '" +instructor.Surname + 
                "',Tel='" + instructor.Tel + "',Address='" + instructor.Address + "',UserRegistered='" + instructor.UserRegistered + "',email='" + instructor.email + "' WHERE (ID='" + instructor.ID + "')");

            }
        }

        public void DeleteInstructor(Instructor instr)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"DELETE FROM Instructors WHERE ID='" + instr.ID + "'");
            }
        }

        //////////////////////////////
        ///END OF Instructor BLOCK////
        //////////////////////////////

        ///////////////////
        ///Member BLOCK////
        ///////////////////

        public List<Member> GetMembers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Member>($"SELECT * FROM Members").ToList();
                return output;
            }
        }

        public List<Member> GetMemberbyID(string ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Member>($"SELECT * FROM Members WHERE ID ='" + ID + "'").ToList();
                return output;
            }
        }
        public List<Member> GetMemberbyTel(string TelNo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Member>($"SELECT * FROM Members WHERE Tel ='" + TelNo + "'").ToList();
                return output;
            }
        }


        public void InsertMember(Member member)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"INSERT INTO Members (Name,Surname,JoinDate,MembershipExp,Age,Address,Tel,email,Balance,Gender,UserRegistered,Instructor,MembershipID) VALUES ('"
                    + member.Name +"','" + member.Surname + "','" + member.JoinDate + "','" + member.MembershipExp + "','" + member.Age + "','" + member.Address + "','" + member.Tel + "','" 
                    + member.email + "','" + member.Balance + "','" + member.Gender + "','" + member.UserRegistered + "','" + member.Instructor + "','" + member.MembershipID + "')");
            }
        }

        public void UpdateMember(Member member)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"UPDATE Members SET Name = '" + member.Name + "',Surname = '" + member.Surname + "',Age='" + member.Age + "',Address='" + member.Address + "',Tel = '" + member.Tel + "',email='" + member.email + "',Balance='" + member.Balance +
                    "',Gender = '" + member.Gender + "',UserRegistered='" + member.UserRegistered + "',Instructor='" + member.Instructor + "',MembershipID='" + member.MembershipID + "' WHERE (ID='" + member.ID + "')");

            }
        }
        public void DeleteMember(Member member)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"DELETE FROM Members WHERE ID='" + member.ID + "'");
            }
        }
        //////////////////////////
        ///END OF Member BLOCK////
        //////////////////////////

        ////////////////////
        ///Payment BLOCK////
        ////////////////////

        public List<Payment> GetPayments()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Payment>($"SELECT * FROM Payments").ToList();
                return output;
            }
        }

        public List<Payment> GetPaymentbyMID(string ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Payment>($"SELECT * FROM Payments WHERE MemberID ='" + ID + "'").ToList();
                return output;
            }
        }
        public List<Payment> GetPaymentDate(DateTime Date1,DateTime Date2)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Payment>($"SELECT * FROM Payments WHERE PDate >'" + Date1 + "' AND PDate <'" + Date2+"'").ToList();
                return output;
            }
        }


        public void InsertPayment(Payment payment)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"INSERT INTO Payments (PTime,PDate,UserID,MemberID,Amount,Note) VALUES ('" + payment.PTime +
                    "','" + payment.PDate + "','" + payment.UserID + "','" + payment.MemberID + "','" + payment.Amount + "','" + payment.Note + "')");
            }
        }


        ///////////////////////////
        ///END OF Payment BLOCK////
        ///////////////////////////
        
        ///////////////////////
        ///Membership BLOCK////
        ///////////////////////
        public List<Membership> GetMemberships()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Membership>($"SELECT * FROM Memberships").ToList();
                return output;
            }
        }

        public string GetMembershipName(string ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Membership>($"SELECT * FROM Memberships WHERE ID ='" + ID + "'").ToList();
                return output[0].Name;
            }
        }


        public void InsertMembership(Membership membership)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"INSERT INTO Memberships (Name,MembershipAmount,UserCreated,MemberShipPeriod) VALUES ('" + membership.Name +
                    "','" + membership.MembershipAmount + "','" + membership.UserCreated + "','" + membership.MembershipPeriod +"')");
            }
        }

        public Membership GetRegMembership ()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                var output = connection.Query<Membership>($"SELECT * FROM Memberships WHERE ID ='1'").ToList();
                return output[0];
            }
        }

        public void DeleteMembership(Membership ms)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"DELETE FROM Memberships WHERE ID='" + ms.ID + "'");
            }
        }
        public void UpdateMembership(Membership ms)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"UPDATE Memberships SET Name = '" + ms.Name + "',MembershipAmount = '" + ms.MembershipAmount + 
                    "',UserCreated='" + ms.UserCreated + "',MemberShipPeriod='" + ms.MembershipPeriod + "' WHERE (ID='" + ms.ID + "')");

            }
        }

        
        //////////////////////////////
        ///END OF Membership BLOCK////
        //////////////////////////////
        
        public void AddMembershipMember(Membership ms,Member mb)
        {
            DateTime MembershipExp = mb.MembershipExp;
            var exp = MembershipExp.AddMonths(ms.MembershipPeriod);
            int Balance = mb.Balance - ms.MembershipAmount;
            

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"UPDATE Members SET MembershipExp = '" + exp + "',Balance = '" + Balance +
                    "',MembershipID='" + ms.ID + "' WHERE (ID='" + mb.ID + "')");

            }
        }
        public void AddPaymentMember(Payment pay, Member mb)
        {
            int Balance = mb.Balance + pay.Amount;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.cnnstring("GymReceptionTool")))
            {
                connection.Execute($"UPDATE Members SET Balance = '" + Balance + "' WHERE (ID='" + mb.ID + "')");
                connection.Execute($"INSERT INTO Payments (PTime,PDate,UserID,MemberID,Amount,Note) VALUES ('"
                    + pay.PTime +"','" + pay.PDate + "','" + pay.UserID + "','" + mb.ID + "','" + pay.Amount + "','" + pay.Note + "')");

            }
        }
    }
}
