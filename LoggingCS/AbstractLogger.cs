using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Logging
{
    public abstract class AbstractLogger : ILogger
    {

        public AbstractLogger() { }
        public void Debug(string module, string message) 
            => Log(LogLevel.Debug, module, message);
        public void Debug(string module, Exception exception) 
            => Log(LogLevel.Debug, module, exception.ToString());
        public void Information(string module, string message) 
            => Log(LogLevel.Information, module, message);
        public void Information(string module, Exception exception) 
            => Log(LogLevel.Information, module, exception.ToString());
        public void Warning(string module, string message) 
            => Log(LogLevel.Warning , module, message);
        public void Warning(string module, Exception exception) 
            => Log(LogLevel.Warning, module, exception.ToString());
        public void Error(string module, string message) 
            => Log(LogLevel.Error, module, message);
        public void Error(string module, Exception exception) 
            => Log(LogLevel.Error, module, exception.ToString());

        protected abstract void Log(LogLevel level, string module, string message);

    }
}
