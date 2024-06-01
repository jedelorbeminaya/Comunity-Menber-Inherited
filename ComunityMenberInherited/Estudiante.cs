using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunityMenberInherited
{
    public class Estudiente : MiembroDeLaComunidad
    {
        public int startDate { get; set; }
        public string? collageGrade { get; set; }

        public string? collageArea { get; set; }
        public  int matricula { get; set; }
    }
}
