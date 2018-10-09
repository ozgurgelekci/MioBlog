﻿using System;
using log4net;

namespace MioBlog.Core.CrossCuttingConcerns.Logging.Log4Net
{
    [Serializable]
    public class LoggerService
    {
        private ILog _log;

        public LoggerService(ILog log)
        {
            _log = log;
        }

        public bool IsInfoEnabled => _log.IsInfoEnabled;
        public bool IsDebugEnabled => _log.IsDebugEnabled;
        public bool IsWarnEnabled => _log.IsWarnEnabled;
        public bool IsFatalEnabled => _log.IsFatalEnabled;
        public bool IsErrorEnabled => _log.IsErrorEnabled;

        public void Info(object logMessage)
        {
            if (IsInfoEnabled)
            {
                _log.Info(logMessage); ;
            }

            if (IsDebugEnabled)
            {
                _log.Debug(logMessage);
            }

            if (IsWarnEnabled)
            {
                _log.Warn(logMessage);
            }

            if (IsFatalEnabled)
            {
                _log.Fatal(logMessage);
            }

            if (IsErrorEnabled)
            {
                _log.Error(logMessage);
            }
        }
    }
}
