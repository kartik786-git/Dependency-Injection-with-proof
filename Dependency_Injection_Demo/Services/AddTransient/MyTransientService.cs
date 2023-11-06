namespace Dependency_Injection_Demo.Services.AddTransient
{
    public class MyTransientService : ITransientService
    {
        private readonly Guid instanceId;
        private readonly List<string> _lists;
        public MyTransientService()
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
