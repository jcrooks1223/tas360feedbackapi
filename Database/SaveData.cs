using System.Data.SQLite;
using System; 
using MySql.Data.MySqlClient;
using API.Models;
namespace API.Database
{
    public class SaveData : ISeedData
    {

        public void SeedData()
        {
                         

            // string cs = @"URI=file:C:\source\repos\TAS-360-Feedback\TAS\feedback1.db";
            //  using var con = new SQLiteConnection(cs);
            //  con.Open();
             DBConnect db = new DBConnect();
            bool isOpen = db.OpenConnection();
            if(isOpen)
            {
              MySqlConnection conn = db.GetConn();
              MySqlCommand cmd = new MySqlCommand();
             
             cmd.Connection = conn;

             cmd.CommandText = "DROP TABLE IF EXISTS feedback";
             cmd.ExecuteNonQuery();

             cmd.CommandText = @"CREATE TABLE feedback(SurveyID INTEGER PRIMARY KEY, Employee_Reviewing TEXT, Employee_Feedback TEXT, Lead1 INTEGER, Lead2 INTEGER, Lead3 INTEGER, Lead4 INTEGER, Lead5 INTEGER, Comm1 INTEGER, Comm2 INTEGER, Comm3 INTEGER, Comm4 INTEGER, Comm5 INTEGER, Tech1 INTEGER, Tech2 INTEGER, Tech3 INTEGER, Tech4 INTEGER, Tech5 INTEGER, LeadTotal INTEGER, CommTotal INTEGER, TechTotal INTEGER, OverallScore INTEGER, SurveyDate DATETIME)";
             cmd.ExecuteNonQuery();


            //EMPLOYEE ONE STARTER VALUE 
             cmd.CommandText = @"INSERT INTO feedback(SurveyID, Employee_Reviewing, Employee_Feedback,
                                Lead1, Lead2, Lead3, Lead4, Lead5,
                                Comm1, Comm2, Comm3, Comm4, Comm5, 
                                Tech1, Tech2, Tech3, Tech4, Tech5, LeadTotal, CommTotal, TechTotal, OverallScore, SurveyDate)
                                VALUES(@SurveyID, @Employee_Reviewing, @Employee_Feedback,
                                @Lead1, @Lead2, @Lead3, @Lead4, @Lead5, 
                                @Comm1, @Comm2, @Comm3, @Comm4, @Comm5, 
                                @Tech1, @Tech2, @Tech3, @Tech4, @Tech5, @LeadTotal, @CommTotal, @TechTotal, @OverallScore, @SurveyDate)";
             cmd.Parameters.AddWithValue("@SurveyID", 1);
             cmd.Parameters.AddWithValue("@Employee_Reviewing", "EmployeeThree");
             cmd.Parameters.AddWithValue("@Employee_Feedback", "EmployeeOne");
             cmd.Parameters.AddWithValue("@Lead1", 1);
             cmd.Parameters.AddWithValue("@Lead2", 1);
             cmd.Parameters.AddWithValue("@Lead3", 1);
             cmd.Parameters.AddWithValue("@Lead4", 1);
             cmd.Parameters.AddWithValue("@Lead5", 1);
             cmd.Parameters.AddWithValue("@Comm1", 2);
             cmd.Parameters.AddWithValue("@Comm2", 2);
             cmd.Parameters.AddWithValue("@Comm3", 2);
             cmd.Parameters.AddWithValue("@Comm4", 2);
             cmd.Parameters.AddWithValue("@Comm5", 2);
             cmd.Parameters.AddWithValue("@Tech1", 3);
             cmd.Parameters.AddWithValue("@Tech2", 3);
             cmd.Parameters.AddWithValue("@Tech3", 3);
             cmd.Parameters.AddWithValue("@Tech4", 3);
             cmd.Parameters.AddWithValue("@Tech5", 3);
             cmd.Parameters.AddWithValue("@LeadTotal", 5);
             cmd.Parameters.AddWithValue("@CommTotal", 10);
             cmd.Parameters.AddWithValue("@TechTotal", 15);
             cmd.Parameters.AddWithValue("@OverallScore", 30); 
             cmd.Parameters.AddWithValue("@SurveyDate", DateTime.Now); 


             cmd.Prepare();
             cmd.ExecuteNonQuery();


            //EMPLOYEE TWO STARTER VALUES
             cmd.CommandText = @"INSERT INTO feedback(SurveyID, Employee_Reviewing, Employee_Feedback,
                               Lead1, Lead2, Lead3, Lead4, Lead5,
                                Comm1, Comm2, Comm3, Comm4, Comm5, 
                                Tech1, Tech2, Tech3, Tech4, Tech5, LeadTotal, CommTotal, TechTotal, OverallScore, SurveyDate) 
                                VALUES(@SurveyID, @Employee_Reviewing, @Employee_Feedback,
                                @Lead1, @Lead2, @Lead3, @Lead4, @Lead5, 
                                @Comm1, @Comm2, @Comm3, @Comm4, @Comm5, 
                                @Tech1, @Tech2, @Tech3, @Tech4, @Tech5, @LeadTotal, @CommTotal, @TechTotal, @OverallScore, @SurveyDate)";
             cmd.Parameters.AddWithValue("@SurveyID", 2);
             cmd.Parameters.AddWithValue("@Employee_Reviewing", "EmployeeOne");
             cmd.Parameters.AddWithValue("@Employee_Feedback", "EmployeeTwo");
             cmd.Parameters.AddWithValue("@Lead1", 2);
             cmd.Parameters.AddWithValue("@Lead2", 2);
             cmd.Parameters.AddWithValue("@Lead3", 2);
             cmd.Parameters.AddWithValue("@Lead4", 2);
             cmd.Parameters.AddWithValue("@Lead5", 2);
             cmd.Parameters.AddWithValue("@Comm1", 3);
             cmd.Parameters.AddWithValue("@Comm2", 3);
             cmd.Parameters.AddWithValue("@Comm3", 3);
             cmd.Parameters.AddWithValue("@Comm4", 3);
             cmd.Parameters.AddWithValue("@Comm5", 3);
             cmd.Parameters.AddWithValue("@Tech1", 4);
             cmd.Parameters.AddWithValue("@Tech2", 4);
             cmd.Parameters.AddWithValue("@Tech3", 4);
             cmd.Parameters.AddWithValue("@Tech4", 4);
             cmd.Parameters.AddWithValue("@Tech5", 4);
             cmd.Parameters.AddWithValue("@LeadTotal", 10);
             cmd.Parameters.AddWithValue("@CommTotal", 15);
             cmd.Parameters.AddWithValue("@TechTotal", 20);
             cmd.Parameters.AddWithValue("@OverallScore", 45); 
             cmd.Parameters.AddWithValue("@SurveyDate", DateTime.Now);

             cmd.Prepare();
             cmd.ExecuteNonQuery(); 



             cmd.CommandText = @"INSERT INTO feedback(SurveyID, Employee_Reviewing, Employee_Feedback,
                               Lead1, Lead2, Lead3, Lead4, Lead5,
                                Comm1, Comm2, Comm3, Comm4, Comm5, 
                                Tech1, Tech2, Tech3, Tech4, Tech5, LeadTotal, CommTotal, TechTotal, OverallScore, SurveyDate) 
                                VALUES(@SurveyID, @Employee_Reviewing, @Employee_Feedback,
                                @Lead1, @Lead2, @Lead3, @Lead4, @Lead5, 
                                @Comm1, @Comm2, @Comm3, @Comm4, @Comm5, 
                                @Tech1, @Tech2, @Tech3, @Tech4, @Tech5, @LeadTotal, @CommTotal, @TechTotal, @OverallScore, @SurveyDate)";
             cmd.Parameters.AddWithValue("@SurveyID", 3);
             cmd.Parameters.AddWithValue("@Employee_Reviewing", "EmployeeTwo");
             cmd.Parameters.AddWithValue("@Employee_Feedback", "EmployeeThree");
             cmd.Parameters.AddWithValue("@Lead1", 3);
             cmd.Parameters.AddWithValue("@Lead2", 3);
             cmd.Parameters.AddWithValue("@Lead3", 3);
             cmd.Parameters.AddWithValue("@Lead4", 3);
             cmd.Parameters.AddWithValue("@Lead5", 3);
             cmd.Parameters.AddWithValue("@Comm1", 4);
             cmd.Parameters.AddWithValue("@Comm2", 4);
             cmd.Parameters.AddWithValue("@Comm3", 4);
             cmd.Parameters.AddWithValue("@Comm4", 4);
             cmd.Parameters.AddWithValue("@Comm5", 4);
             cmd.Parameters.AddWithValue("@Tech1", 5);
             cmd.Parameters.AddWithValue("@Tech2", 5);
             cmd.Parameters.AddWithValue("@Tech3", 5);
             cmd.Parameters.AddWithValue("@Tech4", 5);
             cmd.Parameters.AddWithValue("@Tech5", 5);
             cmd.Parameters.AddWithValue("@LeadTotal", 15);
             cmd.Parameters.AddWithValue("@CommTotal", 20);
             cmd.Parameters.AddWithValue("@TechTotal", 25);
             cmd.Parameters.AddWithValue("@OverallScore", 60); 
             cmd.Parameters.AddWithValue("@SurveyDate", DateTime.Now);


             cmd.Prepare();
             cmd.ExecuteNonQuery();

            }

        }

    }
}