
namespace WolvenKit.RED4.Types
{
	public abstract partial class ObjectScanningDescription : IScriptable
	{
		public ObjectScanningDescription()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
