using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLayersResource : CResource
	{
		[Ordinal(1)] 
		[RED("layerDefinitions")] 
		public inkLayerDefinitionCollection LayerDefinitions
		{
			get => GetPropertyValue<inkLayerDefinitionCollection>();
			set => SetPropertyValue<inkLayerDefinitionCollection>(value);
		}

		[Ordinal(2)] 
		[RED("preGameLayerDefinitions")] 
		public inkLayerDefinitionCollection PreGameLayerDefinitions
		{
			get => GetPropertyValue<inkLayerDefinitionCollection>();
			set => SetPropertyValue<inkLayerDefinitionCollection>(value);
		}

		[Ordinal(3)] 
		[RED("permanentLayerDefinitions")] 
		public inkPermanentLayerDefinitionCollection PermanentLayerDefinitions
		{
			get => GetPropertyValue<inkPermanentLayerDefinitionCollection>();
			set => SetPropertyValue<inkPermanentLayerDefinitionCollection>(value);
		}

		[Ordinal(4)] 
		[RED("layerDefinitionsSet")] 
		public inkLayerDefinitionsSet LayerDefinitionsSet
		{
			get => GetPropertyValue<inkLayerDefinitionsSet>();
			set => SetPropertyValue<inkLayerDefinitionsSet>(value);
		}

		public inkLayersResource()
		{
			LayerDefinitions = new() { MenuLayer = new(), MenuLayerMP = new(), HudLayer = new(), VideoLayer = new(), OffscreenLayer = new(), GameNotificationsLayer = new(), PhotoModeLayer = new(), DebugLayer = new() { Entries = new() } };
			PreGameLayerDefinitions = new() { MenuLayer = new(), MenuLayerMP = new(), HudLayer = new(), VideoLayer = new(), OffscreenLayer = new(), GameNotificationsLayer = new(), PhotoModeLayer = new(), DebugLayer = new() { Entries = new() } };
			PermanentLayerDefinitions = new() { LoadingLayer = new(), WatermarksLayer = new(), SysNotificationsLayer = new(), WaitingSignLayerDefinition = new() };
			LayerDefinitionsSet = new() { LayersDefinitions = new(), LayersSystemConnections = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
