using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace di_console_app
{
    public interface IGrettingService
    {
        void Run();
    }

    public sealed class GrettingService : IGrettingService
    {
        private readonly ILogger<GrettingService> _log;
        private readonly IConfiguration _config;

        public GrettingService(ILogger<GrettingService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }

        public void Run()
        {
            for (int i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
            {
                _log.LogInformation("Run number {runNumber}", i);
            }
        }
    }
}