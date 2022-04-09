
namespace WolvenKit.RED4.Types
{
	public partial class netEntitySystem : worldIRuntimeSystem
	{
		public netEntitySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
