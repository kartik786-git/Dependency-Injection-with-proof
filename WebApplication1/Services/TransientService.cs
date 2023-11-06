namespace WebApplication1.Services
{
    public class TransientService : IMyService
    {
        private int _count;

        public TransientService()
        {
            _count = 0;
        }

        public int GetCount()
        {
            return _count++;
        }
    }
}
