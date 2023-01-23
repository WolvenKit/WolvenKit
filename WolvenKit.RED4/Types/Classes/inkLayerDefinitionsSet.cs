using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLayerDefinitionsSet : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("layersDefinitions")] 
		public CArray<inkLayerDefinition_NEW> LayersDefinitions
		{
			get => GetPropertyValue<CArray<inkLayerDefinition_NEW>>();
			set => SetPropertyValue<CArray<inkLayerDefinition_NEW>>(value);
		}

		[Ordinal(1)] 
		[RED("layersSystemConnections")] 
		public CArray<inkLayerSystemConnection> LayersSystemConnections
		{
			get => GetPropertyValue<CArray<inkLayerSystemConnection>>();
			set => SetPropertyValue<CArray<inkLayerSystemConnection>>(value);
		}

		public inkLayerDefinitionsSet()
		{
			LayersDefinitions = new();
			LayersSystemConnections = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
