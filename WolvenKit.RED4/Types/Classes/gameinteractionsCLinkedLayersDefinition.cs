using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsCLinkedLayersDefinition : gameinteractionsNodeDefinition
	{
		[Ordinal(0)] 
		[RED("layersDefinitions")] 
		public CArray<CHandle<gameinteractionsCHotSpotLayerDefinition>> LayersDefinitions
		{
			get => GetPropertyValue<CArray<CHandle<gameinteractionsCHotSpotLayerDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<gameinteractionsCHotSpotLayerDefinition>>>(value);
		}

		[Ordinal(1)] 
		[RED("visualizerDefinition")] 
		public CHandle<gameinteractionsvisIVisualizerDefinition> VisualizerDefinition
		{
			get => GetPropertyValue<CHandle<gameinteractionsvisIVisualizerDefinition>>();
			set => SetPropertyValue<CHandle<gameinteractionsvisIVisualizerDefinition>>(value);
		}

		[Ordinal(2)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameinteractionsCLinkedLayersDefinition()
		{
			LayersDefinitions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
