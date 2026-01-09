using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace untyStore
{
    public interface IBootsRepository
    {
        Boot[] GetAllByTitle(string titlePart);
    }
}
