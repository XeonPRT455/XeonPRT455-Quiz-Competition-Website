using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizCompetition.Controllers
{
    public class LogController : ApiController
    {
        private ILog _log;

        public LogController(ILog log)
        {
            _log = log;
        }
        public IHttpActionResult Get()
        {
            _log.Debug("Debug", new Exception("DebugException"));
            _log.Info("Info", new Exception("InfoException"));
            _log.Warn("Warn", new Exception("WarnException"));
            _log.Error("Error", new Exception("ErrorException"));
            _log.Fatal("Fatal", new Exception("FatalException"));
            return Ok("wrote in log file");
        }
    }
}


