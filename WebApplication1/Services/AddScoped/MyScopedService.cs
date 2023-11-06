namespace Dependency_Injection_Demo.Services.AddScoped
{
    public class MyScopedService : IScopedService
    {
        private readonly Guid instanceId;

        public MyScopedService()
        {
            instanceId = Guid.NewGuid();
        }

        public Guid GetInstanceId()
        {
            return instanceId;
        }
    }

}
