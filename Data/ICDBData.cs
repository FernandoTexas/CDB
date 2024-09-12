using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Domain;

namespace Data
{
    public interface ICDBData
    {
        Task<double> CalculaCDB(CDBViweModel cdb);
    }
}
