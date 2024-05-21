using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team.Repository.Interface
{
    public interface IUnitOfWork<T>:IDisposable
    {
        public int Completed();
    }
}
