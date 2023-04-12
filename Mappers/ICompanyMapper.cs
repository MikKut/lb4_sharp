using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public interface ICompanyMapper<Domain, Entity>
        where Domain : class 
        where Entity : class
    {
        public Domain ToDomain(Entity entity);
        public Entity ToEntity(Domain domain);
    }
}
