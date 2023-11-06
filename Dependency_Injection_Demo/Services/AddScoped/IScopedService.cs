namespace Dependency_Injection_Demo.Services.AddScoped
{
    public interface IScopedService
    {
        Guid GetInstanceId();
        List<string> GetList();

        void Insert(string value);
    }
}