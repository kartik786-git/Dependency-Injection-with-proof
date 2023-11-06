namespace Dependency_Injection_Demo.Services.AddSingleton
{
    public interface ISingletonService
    {
        Guid GetInstanceId();
        List<string> GetList();

        void Insert(string value);
    }
}