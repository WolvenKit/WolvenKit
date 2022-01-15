using System.Threading.Tasks;
using System.Windows.Input;

namespace WolvenKit.Functionality.Commands
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }
}
