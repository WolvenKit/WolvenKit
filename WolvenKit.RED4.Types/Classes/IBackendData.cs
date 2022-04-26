
namespace WolvenKit.RED4.Types
{
	public partial class IBackendData : ISerializable
	{
		public IBackendData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
