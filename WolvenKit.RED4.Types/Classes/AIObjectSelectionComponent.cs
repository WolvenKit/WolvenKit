
namespace WolvenKit.RED4.Types
{
	public partial class AIObjectSelectionComponent : entIComponent
	{
		public AIObjectSelectionComponent()
		{
			Name = "ObjectSelector";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
