using System.Collections.Generic;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace API.Models.Interfaces
{
    public interface IGetSurvey
    {
        Survey GetSurvey(int id);
    }
}