using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLayerDefinitionCollection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("menuLayer")] 
		public inkMenuLayerDefinition MenuLayer
		{
			get => GetPropertyValue<inkMenuLayerDefinition>();
			set => SetPropertyValue<inkMenuLayerDefinition>(value);
		}

		[Ordinal(1)] 
		[RED("menuLayerMP")] 
		public inkMenuLayerDefinition MenuLayerMP
		{
			get => GetPropertyValue<inkMenuLayerDefinition>();
			set => SetPropertyValue<inkMenuLayerDefinition>(value);
		}

		[Ordinal(2)] 
		[RED("hudLayer")] 
		public inkHUDLayerDefinition HudLayer
		{
			get => GetPropertyValue<inkHUDLayerDefinition>();
			set => SetPropertyValue<inkHUDLayerDefinition>(value);
		}

		[Ordinal(3)] 
		[RED("videoLayer")] 
		public inkVideoLayerDefinition VideoLayer
		{
			get => GetPropertyValue<inkVideoLayerDefinition>();
			set => SetPropertyValue<inkVideoLayerDefinition>(value);
		}

		[Ordinal(4)] 
		[RED("offscreenLayer")] 
		public inkOffscreenLayerDefinition OffscreenLayer
		{
			get => GetPropertyValue<inkOffscreenLayerDefinition>();
			set => SetPropertyValue<inkOffscreenLayerDefinition>(value);
		}

		[Ordinal(5)] 
		[RED("gameNotificationsLayer")] 
		public inkGameNotificationsLayerDefinition GameNotificationsLayer
		{
			get => GetPropertyValue<inkGameNotificationsLayerDefinition>();
			set => SetPropertyValue<inkGameNotificationsLayerDefinition>(value);
		}

		[Ordinal(6)] 
		[RED("photoModeLayer")] 
		public inkPhotoModeLayerDefinition PhotoModeLayer
		{
			get => GetPropertyValue<inkPhotoModeLayerDefinition>();
			set => SetPropertyValue<inkPhotoModeLayerDefinition>(value);
		}

		[Ordinal(7)] 
		[RED("debugLayer")] 
		public inkDebugLayerDefinition DebugLayer
		{
			get => GetPropertyValue<inkDebugLayerDefinition>();
			set => SetPropertyValue<inkDebugLayerDefinition>(value);
		}

		public inkLayerDefinitionCollection()
		{
			MenuLayer = new();
			MenuLayerMP = new();
			HudLayer = new();
			VideoLayer = new();
			OffscreenLayer = new();
			GameNotificationsLayer = new();
			PhotoModeLayer = new();
			DebugLayer = new() { Entries = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
