using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Domain
{
    public interface ITwitterClient
    {
        string Search(string searchWord);
    }
}
