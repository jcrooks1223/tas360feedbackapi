using System.Collections.Generic;
using System.Data.SQLite;
using API.Models.Interfaces;
using System; 
using MySql.Data.MySqlClient;

namespace API.Models
{
    public class ReadFeedbackData: IGetAllSurveys, IGetSurvey
    {

        public List<Survey> GetAllSurveys()
        {
            DBConnect db = new DBConnect();
            bool isOpen =db.OpenConnection();

            if(isOpen)
            {
                MySqlConnection conn = db.GetConn();
                string stm = "SELECT * FROM feedback";
                MySqlCommand cmd = new MySqlCommand(stm,conn);

                List<Survey> allSurveys = new List<Survey>();

                using(var rdr = cmd.ExecuteReader())
                {
                    while(rdr.Read()){
                        Survey temp = new Survey(){SurveyID=rdr.GetInt32(0), 
                                            Employee_Reviewing = rdr.GetString(1),
                                            Employee_Feedback=rdr.GetString(2),
                                            Lead1=rdr.GetInt32(3),
                                            Lead2=rdr.GetInt32(4),
                                            Lead3=rdr.GetInt32(5),
                                            Lead4=rdr.GetInt32(6),
                                            Lead5=rdr.GetInt32(7),
                                            Comm1=rdr.GetInt32(8),
                                            Comm2=rdr.GetInt32(9),
                                            Comm3=rdr.GetInt32(10),
                                            Comm4=rdr.GetInt32(11),
                                            Comm5=rdr.GetInt32(12),
                                            Tech1=rdr.GetInt32(13),
                                            Tech2=rdr.GetInt32(14),
                                            Tech3=rdr.GetInt32(15),
                                            Tech4=rdr.GetInt32(16),
                                            Tech5=rdr.GetInt32(17),
                                            LeadTotal=rdr.GetInt32(18),
                                            CommTotal=rdr.GetInt32(19),
                                            TechTotal=rdr.GetInt32(20),
                                            OverallScore=rdr.GetInt32(21),
                                            SurveyDate=rdr.GetDateTime(22)}; 
 
                       allSurveys.Add(temp);
                    }
                }
                db.CloseConnection();
                return allSurveys;
            }
            else
            {
                return new List<Survey>();
            }
            // string cs = @"URI=file:C:\source\repos\TAS-360-Feedback\TAS\feedback1.db";
            // //string cs = @"URI=file:C:\Users\Emily Moye\source\repos\TAS-360-Feedback\TAS\feedback1.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open();

            // string stm = "SELECT * FROM feedback";
            // using var cmd = new SQLiteCommand(stm, con);

            // using SQLiteDataReader rdr = cmd.ExecuteReader();

            // List<Survey> allSurveys = new List<Survey>();

            // while(rdr.Read())
            // {
                
            //     Survey temp = new Survey(){SurveyID=rdr.GetInt32(0), 
            //                                 Employee_Reviewing = rdr.GetString(1),
            //                                 Employee_Feedback=rdr.GetString(2),
            //                                 Lead1=rdr.GetInt32(3),
            //                                 Lead2=rdr.GetInt32(4),
            //                                 Lead3=rdr.GetInt32(5),
            //                                 Lead4=rdr.GetInt32(6),
            //                                 Lead5=rdr.GetInt32(7),
            //                                 Comm1=rdr.GetInt32(8),
            //                                 Comm2=rdr.GetInt32(9),
            //                                 Comm3=rdr.GetInt32(10),
            //                                 Comm4=rdr.GetInt32(11),
            //                                 Comm5=rdr.GetInt32(12),
            //                                 Tech1=rdr.GetInt32(13),
            //                                 Tech2=rdr.GetInt32(14),
            //                                 Tech3=rdr.GetInt32(15),
            //                                 Tech4=rdr.GetInt32(16),
            //                                 Tech5=rdr.GetInt32(17),
            //                                 LeadTotal=rdr.GetInt32(18),
            //                                 CommTotal=rdr.GetInt32(19),
            //                                 TechTotal=rdr.GetInt32(20),
            //                                 OverallScore=rdr.GetInt32(21),
            //                                 SurveyDate=rdr.GetDateTime(22)}; 
 
            //     allSurveys.Add(temp);
            // }

            // return allSurveys;
        }

        public Survey GetSurvey(int id)
        {
            // string cs = @"URI=file:C:\source\repos\TAS-360-Feedback\TAS\feedback1.db";
            // using var con = new SQLiteConnection(cs);
            // con.Open();
            
            DBConnect db = new DBConnect();
            bool isOpen = db.OpenConnection();
            if(isOpen)
            {
             MySqlConnection conn = db.GetConn();
             string stm = "SELECT * FROM feedback WHERE SurveyID=@SurveyID";
             MySqlCommand cmd = new MySqlCommand(stm,conn);

             cmd.Connection = conn;
             cmd.CommandText = @"SELECT * FROM feedback WHERE SurveyID=@SurveyID";
             cmd.Parameters.AddWithValue("@SurveyID", id);
             cmd.Prepare();
             //cmd.ExecuteNonQuery();
             

             using(var rdr = cmd.ExecuteReader())
             {
               rdr.Read();
               db.CloseConnection();
                
                  return new Survey(){SurveyID=rdr.GetInt32(0), 
                                            Employee_Reviewing = rdr.GetString(1),
                                            Employee_Feedback=rdr.GetString(2),
                                            Lead1=rdr.GetInt32(3),
                                            Lead2=rdr.GetInt32(4),
                                            Lead3=rdr.GetInt32(5),
                                            Lead4=rdr.GetInt32(6),
                                            Lead5=rdr.GetInt32(7),
                                            Comm1=rdr.GetInt32(8),
                                            Comm2=rdr.GetInt32(9),
                                            Comm3=rdr.GetInt32(10),
                                            Comm4=rdr.GetInt32(11),
                                            Comm5=rdr.GetInt32(12),
                                            Tech1=rdr.GetInt32(13),
                                            Tech2=rdr.GetInt32(14),
                                            Tech3=rdr.GetInt32(15),
                                            Tech4=rdr.GetInt32(16),
                                            Tech5=rdr.GetInt32(17),
                                            LeadTotal=rdr.GetInt32(18), 
                                            CommTotal=rdr.GetInt32(19),
                                            TechTotal=rdr.GetInt32(20), 
                                            OverallScore=rdr.GetInt32(21),
                                            SurveyDate=rdr.GetDateTime(22)};   
             }
             
            }
            
            else
            {
                return new Survey();
            }
            
        }
        
    }
}
