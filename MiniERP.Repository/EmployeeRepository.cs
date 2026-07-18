using MiniERP.Core.Interfaces.Repositories;
using MiniERP.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DapperContext _dapperContext;
        public EmployeeRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }
    }
}
