using System.Collections.Generic;
using System.Data.SQLite;

namespace API.Models.Interfaces
{
    public interface IGetSurvey
    {
        Survey GetSurvey(int id);
    }
}