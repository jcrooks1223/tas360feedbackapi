using System; 
namespace API.Models
{
    public class Survey
    {
        public int SurveyID {get; set;}

        public string Employee_Reviewing {get; set;}

        public string Employee_Feedback {get; set;}

        public int Lead1 {get; set;}

        public int Lead2 {get; set;}
        
        public int Lead3 {get; set;}

        public int Lead4 {get; set;}

        public int Lead5 {get; set;}

        public int Comm1 {get; set;}

        public int Comm2 {get; set;}
        
        public int Comm3 {get; set;}

        public int Comm4 {get; set;}

        public int Comm5 {get; set;}

        public int Tech1 {get; set;}

        public int Tech2 {get; set;}
        
        public int Tech3 {get; set;}

        public int Tech4 {get; set;}

        public int Tech5 {get; set;}

        public int LeadTotal {get; set;}

        public int CommTotal {get; set;}

        public int TechTotal {get; set;}

        public int OverallScore {get; set;}

        public DateTime SurveyDate {get; set;}


        public override string ToString()
        {
            return SurveyID + " Overall Results " + (Lead1 + Lead2 + Lead3 + Lead4 + Lead5 + Comm1 + Comm2 + Comm3 + Comm4 + Comm5 + Tech1 + Tech2 + Tech3 + Tech4 + Tech5);
        }
    }
}