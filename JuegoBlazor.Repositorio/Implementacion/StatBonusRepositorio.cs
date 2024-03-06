using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JuegoBlazor.Repositorio.DBContext;
using JuegoBlazor.Repositorio.Contrato;
using JuegoBlazor.Modelo;

namespace JuegoBlazor.Repositorio.Implementacion
{
    public class StatBonusRepositorio : GenericoRepositorio<StatBonus>, IStatBonusRepositorio
    {
        private readonly L2testGame2Context _dbContext;

        public StatBonusRepositorio(L2testGame2Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
