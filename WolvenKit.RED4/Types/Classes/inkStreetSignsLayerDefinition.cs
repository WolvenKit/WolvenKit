
namespace WolvenKit.RED4.Types
{
	public partial class inkStreetSignsLayerDefinition : inkLayerDefinition
	{
		public inkStreetSignsLayerDefinition()
		{
			ActiveByDefault = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
