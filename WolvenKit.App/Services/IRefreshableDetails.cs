namespace WolvenKit.App.Services
{
    /// <summary>
    /// Interface for nodes that can refresh their detail information
    /// </summary>
    public interface IRefreshableDetails
    {
        /// <summary>
        /// Refresh the node's detail information from the underlying data
        /// </summary>
        void RefreshDetails();
    }
} 