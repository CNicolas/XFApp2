using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFApp2.Services
{
    public interface ISaveAndLoadService
    {
        void SaveText(string filename, string text);
        string LoadText(string filename);
    }
}
