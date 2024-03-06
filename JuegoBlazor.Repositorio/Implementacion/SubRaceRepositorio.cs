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
    public class SubRaceRepositorio : GenericoRepositorio<SubRace>, ISubRaceRepositorio
    {
        private readonly L2testGame2Context _dbContext;

        public SubRaceRepositorio(L2testGame2Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }

}
