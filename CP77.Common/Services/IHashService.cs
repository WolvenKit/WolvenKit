using System.Threading.Tasks;

namespace CP77Tools.Common.Services
{
    public interface IHashService
    {
        Task<bool> RefreshAsync();
    }
}
