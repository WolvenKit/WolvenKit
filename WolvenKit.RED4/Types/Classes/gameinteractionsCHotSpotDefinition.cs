using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsCHotSpotDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("suppressor")] 
		public CBool Suppressor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("layersDefinition")] 
		public CArray<CHandle<gameinteractionsCLinkedLayersDefinition>> LayersDefinition
		{
			get => GetPropertyValue<CArray<CHandle<gameinteractionsCLinkedLayersDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<gameinteractionsCLinkedLayersDefinition>>>(value);
		}

		public gameinteractionsCHotSpotDefinition()
		{
			LayersDefinition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
