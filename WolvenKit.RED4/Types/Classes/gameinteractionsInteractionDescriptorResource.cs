using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsInteractionDescriptorResource : CResource
	{
		[Ordinal(1)] 
		[RED("definition")] 
		public gameinteractionsCHotSpotDefinition Definition
		{
			get => GetPropertyValue<gameinteractionsCHotSpotDefinition>();
			set => SetPropertyValue<gameinteractionsCHotSpotDefinition>(value);
		}

		public gameinteractionsInteractionDescriptorResource()
		{
			Definition = new gameinteractionsCHotSpotDefinition { LayersDefinition = new() { null } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
