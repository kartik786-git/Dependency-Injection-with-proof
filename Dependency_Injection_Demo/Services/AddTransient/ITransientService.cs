namespace Dependency_Injection_Demo.Services.AddTransient
{
    public interface ITransientService
    {
        Guid GetInstanceId();
        List<string> GetList();

        void Insert(string value);
    }
}