namespace Metanit
{
    public class Worker1 : IWorker
    {
        ILogger Logger { get; }

        public Worker1(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker1 started working.");
            Thread.Sleep(3000);
            Logger.Event("Worker1 finished working");
        }
    }
}
