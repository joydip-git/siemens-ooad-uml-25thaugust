namespace DIPApp
{
    public class ExceptionLoggerManager
    {
        private readonly ILogger logger;

        public ExceptionLoggerManager(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogException(Exception error)
        {
            logger.LogError(error);
        }
    }
}