namespace Dependency_Injection_Demo.Services.AddScoped
{
    public class MyScopedService : IScopedService
    {
        private readonly Guid instanceId;
        private readonly List<string> _lists;
        public MyScopedService()
        {
            instanceId = Guid.NewGuid();
            _lists = new List<string>();
        }

        public Guid GetInstanceId()
        {
            return instanceId;
        }

        public List<string> GetList()
        {
            return _lists;
        }

        public void Insert(string value)
        {
            _lists.Add(value);
        }
    }

}
