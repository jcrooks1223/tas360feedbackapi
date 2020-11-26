using System.Threading.Tasks.Sources;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Data.SQLite;
using API.Models.Interfaces;
using System; 
using MySql.Data.MySqlClient;

namespace API.Models
{
    public class SaveSurvey: IInsertSurvey
    {
        public void InsertSurvey(Survey value)
        {
            // string cs = @"URI=file:C:\source\repos\TAS-360-Feedback\TAS\feedback1.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open();

            // using var cmd = new SQLiteCommand(con);
            DBConnect db = new DBConnect();
            bool isOpen = db.OpenConnection();
            if(isOpen)
            {
               MySqlConnection conn = db.GetConn();
               MySqlCommand cmd = new MySqlCommand();
            
             cmd.CommandText = @"INSERT INTO feedback(Employee_Reviewing, Employee_Feedback,
                                Lead1, Lead2, Lead3, Lead4, Lead5,
                                Comm1, Comm2, Comm3, Comm4, Comm5, 
                                Tech1, Tech2, Tech3, Tech4, Tech5, LeadTotal, CommTotal, TechTotal, OverallScore, SurveyDate) 
                                VALUES(@Employee_Reviewing, @Employee_Feedback,
                                @Lead1, @Lead2, @Lead3, @Lead4, @Lead5, 
                                @Comm1, @Comm2, @Comm3, @Comm4, @Comm5, 
                                @Tech1, @Tech2, @Tech3, @Tech4, @Tech5, @LeadTotal, @CommTotal, @TechTotal, @OverallScore, @SurveyDate)";
             //cmd.Parameters.AddWithValue("@SurveyID", value.SurveyID);
             cmd.Parameters.AddWithValue("@Employee_Reviewing", value.Employee_Reviewing);
             cmd.Parameters.AddWithValue("@Employee_Feedback", value.Employee_Feedback);
             cmd.Parameters.AddWithValue("@Lead1", value.Lead1);
             cmd.Parameters.AddWithValue("@Lead2", value.Lead2);
             cmd.Parameters.AddWithValue("@Lead3", value.Lead3);
             cmd.Parameters.AddWithValue("@Lead4", value.Lead4);
             cmd.Parameters.AddWithValue("@Lead5", value.Lead5);
             cmd.Parameters.AddWithValue("@Comm1", value.Comm1);
             cmd.Parameters.AddWithValue("@Comm2", value.Comm2);
             cmd.Parameters.AddWithValue("@Comm3", value.Comm3);
             cmd.Parameters.AddWithValue("@Comm4", value.Comm4);
             cmd.Parameters.AddWithValue("@Comm5", value.Comm5);
             cmd.Parameters.AddWithValue("@Tech1", value.Tech1);
             cmd.Parameters.AddWithValue("@Tech2", value.Tech2);
             cmd.Parameters.AddWithValue("@Tech3", value.Tech3);
             cmd.Parameters.AddWithValue("@Tech4", value.Tech4);
             cmd.Parameters.AddWithValue("@Tech5", value.Tech5);
             cmd.Parameters.AddWithValue("@LeadTotal", value.LeadTotal); 
             cmd.Parameters.AddWithValue("@CommTotal", value.CommTotal); 
             cmd.Parameters.AddWithValue("@TechTotal", value.TechTotal); 
             cmd.Parameters.AddWithValue("@OverallScore", value.OverallScore);
             cmd.Parameters.AddWithValue("@SurveyDate", DateTime.Now); 
            
             cmd.Prepare();
             cmd.ExecuteNonQuery();

             db.CloseConnection();
            }
        }
    }
}