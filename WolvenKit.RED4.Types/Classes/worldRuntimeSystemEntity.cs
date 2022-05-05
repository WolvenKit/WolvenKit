
namespace WolvenKit.RED4.Types
{
	public partial class worldRuntimeSystemEntity : worldIRuntimeSystem
	{
		public worldRuntimeSystemEntity()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
