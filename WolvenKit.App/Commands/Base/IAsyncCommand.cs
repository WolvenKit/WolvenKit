using System.Threading.Tasks;
using System.Windows.Input;

namespace WolvenKit.App.Commands.Base
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }
}
