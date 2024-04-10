namespace WillsStore.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
