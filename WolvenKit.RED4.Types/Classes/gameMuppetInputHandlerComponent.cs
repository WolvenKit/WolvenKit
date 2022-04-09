
namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetInputHandlerComponent : entIComponent
	{
		public gameMuppetInputHandlerComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
