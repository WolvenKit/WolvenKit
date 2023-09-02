
namespace WolvenKit.RED4.Types
{
	public abstract partial class IRenderResourceBlob : ISerializable
	{
		public IRenderResourceBlob()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
