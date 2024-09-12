using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application.Services
{
    public class CdbAppService : ICdbAppService
    {
        private readonly ICdb _cdb;      
        public CdbAppService(ICdb cdb)
        {
            _cdb = cdb;            
        }
        public double Valor { get; set; }
        public double Meses { get; set; }

        public async Task<ResultadoCdb> CalculaCDB(CdbViweModel cdb)
        {
            return await _cdb.CalculaCDB(cdb.Valor, cdb.Meses);
            
        }      
    }
}
