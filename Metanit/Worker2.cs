namespace Metanit
{
    public class Worker2 : IWorker
    {
        ILogger Logger { get; }

        public Worker2(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker2 started working.");
            Thread.Sleep(3000);
            Logger.Event("Worker2 finished working");
        }
    }
}
