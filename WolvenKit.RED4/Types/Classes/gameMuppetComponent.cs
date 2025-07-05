
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameMuppetComponent : entIComponent
	{
		public gameMuppetComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
