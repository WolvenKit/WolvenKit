
namespace WolvenKit.RED4.Types
{
	public partial class HighlightModule : HUDModule
	{
		public HighlightModule()
		{
			InstancesList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
