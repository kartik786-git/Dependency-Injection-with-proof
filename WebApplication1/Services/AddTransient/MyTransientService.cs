namespace Dependency_Injection_Demo.Services.AddTransient
{
    public class MyTransientService : ITransientService
    {
        private readonly Guid instanceId;

        public MyTransientService()
        {
            instanceId = Guid.NewGuid();
        }

        public Guid GetInstanceId()
        {
            return instanceId;
        }
    }

}
