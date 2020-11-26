using System.Xml.Schema;
using System.Collections.Generic;
using System.Data.SQLite;
using API.Database;
using MySql.Data.MySqlClient;

namespace API.Models.Interfaces
{
    public interface IInsertSurvey
    {
        public void InsertSurvey(Survey value);
    }
}