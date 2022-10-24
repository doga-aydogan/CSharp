using Engine;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var workfllowEngine = new WorkflowEngine();
            workfllowEngine.AddActivity(new UploadVideo());
            workfllowEngine.AddActivity(new NofityVideoOwnwer());
            workfllowEngine.AddActivity(new EncodeVideo());
            workfllowEngine.Run();
            
        }
    }
}
