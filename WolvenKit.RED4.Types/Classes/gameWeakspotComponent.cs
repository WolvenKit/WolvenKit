
namespace WolvenKit.RED4.Types
{
	public partial class gameWeakspotComponent : entIComponent
	{
		public gameWeakspotComponent()
		{
			Name = "Component";
			IsReplicable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
