namespace Metanit
{
    public class Worker3 : IWorker
    {
        ILogger Logger { get; }

        public Worker3(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker3 started working.");
            Thread.Sleep(3000);
            Logger.Event("Worker3 finished working");
        }
    }
}
