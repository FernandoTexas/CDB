using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class CdbViweModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Meses { get; set; }
    }
}
