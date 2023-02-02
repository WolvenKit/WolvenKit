
namespace WolvenKit.RED4.Types
{
	public partial class gameSimpleOccupantSlotSpawner : entIComponent
	{
		public gameSimpleOccupantSlotSpawner()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
