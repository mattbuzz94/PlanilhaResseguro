using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanilhaResseguro.Model
{
    class PlanilhaResseguro
    {
        string pathPlanilhaOriginal;
        string pathPlanilhaFormatada;
        string idJira;

        public string PathPlanilhaOriginal { get => pathPlanilhaOriginal; set => pathPlanilhaOriginal = value; }
        public string PathPlanilhaFormatada { get => pathPlanilhaFormatada; set => pathPlanilhaFormatada = value; }
        public string IdJira { get => idJira; set => idJira = value; }
    }
}
