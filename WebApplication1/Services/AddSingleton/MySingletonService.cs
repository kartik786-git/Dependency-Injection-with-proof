
using System.Reflection.Metadata;

namespace Dependency_Injection_Demo.Services.AddSingleton
{
    public class MySingletonService : ISingletonService
    {
        private readonly Guid instanceId;

        private readonly List<string> _lists;


        public MySingletonService()
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
