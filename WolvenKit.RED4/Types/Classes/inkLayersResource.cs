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
			LayerDefinitions = new inkLayerDefinitionCollection { MenuLayer = new inkMenuLayerDefinition(), MenuLayerMP = new inkMenuLayerDefinition(), HudLayer = new inkHUDLayerDefinition(), VideoLayer = new inkVideoLayerDefinition(), OffscreenLayer = new inkOffscreenLayerDefinition(), GameNotificationsLayer = new inkGameNotificationsLayerDefinition(), PhotoModeLayer = new inkPhotoModeLayerDefinition(), DebugLayer = new inkDebugLayerDefinition { Entries = new() } };
			PreGameLayerDefinitions = new inkLayerDefinitionCollection { MenuLayer = new inkMenuLayerDefinition(), MenuLayerMP = new inkMenuLayerDefinition(), HudLayer = new inkHUDLayerDefinition(), VideoLayer = new inkVideoLayerDefinition(), OffscreenLayer = new inkOffscreenLayerDefinition(), GameNotificationsLayer = new inkGameNotificationsLayerDefinition(), PhotoModeLayer = new inkPhotoModeLayerDefinition(), DebugLayer = new inkDebugLayerDefinition { Entries = new() } };
			PermanentLayerDefinitions = new inkPermanentLayerDefinitionCollection { LoadingLayer = new inkLoadingLayerDefinition(), WatermarksLayer = new inkWatermarksLayerDefinition(), SysNotificationsLayer = new inkSystemNotificationsLayerDefinition(), WaitingSignLayerDefinition = new inkWaitingSignLayerDefinition() };
			LayerDefinitionsSet = new inkLayerDefinitionsSet { LayersDefinitions = new(), LayersSystemConnections = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
