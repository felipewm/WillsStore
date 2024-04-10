using WillsStore.Core.Messages;

namespace WillsStore.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;


    }
}
