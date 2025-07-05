
namespace WolvenKit.RED4.Types
{
	public abstract partial class IBackendData : ISerializable
	{
		public IBackendData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
