namespace WebApplication1.Services
{
    public class ScopedService : IMyService
    {
        private int _count;

        public ScopedService()
        {
            _count = 0;
        }

        public int GetCount()
        {
            return _count++;
        }
    }
}