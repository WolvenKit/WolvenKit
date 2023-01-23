
namespace WolvenKit.RED4.Types
{
	public partial class questGraphDefinition : graphGraphDefinition
	{
		public questGraphDefinition()
		{
			Nodes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
