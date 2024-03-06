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
    public class ClassRepositorio : GenericoRepositorio<Class>, IClassRepositorio
    {
        private readonly L2testGame2Context _dbContext;

        public ClassRepositorio(L2testGame2Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }

}
