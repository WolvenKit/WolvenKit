using System.Threading.Tasks;

namespace AlphaChiTech.Virtualization.Pageing
{
    public interface IAsyncResetProvider
    {
        Task<int> GetCountAsync();
    }
}