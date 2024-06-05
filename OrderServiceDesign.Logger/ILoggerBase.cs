using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceDesign.Logger
{
    public interface ILoggerBase
    {
        void Debug(string message);
        void Information(string message);
        void Warning(string message);
        void Error(string message);
    }
}
