using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLayerDefinitionCollection : RedBaseClass
	{
		private inkMenuLayerDefinition _menuLayer;
		private inkMenuLayerDefinition _menuLayerMP;
		private inkHUDLayerDefinition _hudLayer;
		private inkVideoLayerDefinition _videoLayer;
		private inkOffscreenLayerDefinition _offscreenLayer;
		private inkGameNotificationsLayerDefinition _gameNotificationsLayer;
		private inkPhotoModeLayerDefinition _photoModeLayer;
		private inkDebugLayerDefinition _debugLayer;

		[Ordinal(0)] 
		[RED("menuLayer")] 
		public inkMenuLayerDefinition MenuLayer
		{
			get => GetProperty(ref _menuLayer);
			set => SetProperty(ref _menuLayer, value);
		}

		[Ordinal(1)] 
		[RED("menuLayerMP")] 
		public inkMenuLayerDefinition MenuLayerMP
		{
			get => GetProperty(ref _menuLayerMP);
			set => SetProperty(ref _menuLayerMP, value);
		}

		[Ordinal(2)] 
		[RED("hudLayer")] 
		public inkHUDLayerDefinition HudLayer
		{
			get => GetProperty(ref _hudLayer);
			set => SetProperty(ref _hudLayer, value);
		}

		[Ordinal(3)] 
		[RED("videoLayer")] 
		public inkVideoLayerDefinition VideoLayer
		{
			get => GetProperty(ref _videoLayer);
			set => SetProperty(ref _videoLayer, value);
		}

		[Ordinal(4)] 
		[RED("offscreenLayer")] 
		public inkOffscreenLayerDefinition OffscreenLayer
		{
			get => GetProperty(ref _offscreenLayer);
			set => SetProperty(ref _offscreenLayer, value);
		}

		[Ordinal(5)] 
		[RED("gameNotificationsLayer")] 
		public inkGameNotificationsLayerDefinition GameNotificationsLayer
		{
			get => GetProperty(ref _gameNotificationsLayer);
			set => SetProperty(ref _gameNotificationsLayer, value);
		}

		[Ordinal(6)] 
		[RED("photoModeLayer")] 
		public inkPhotoModeLayerDefinition PhotoModeLayer
		{
			get => GetProperty(ref _photoModeLayer);
			set => SetProperty(ref _photoModeLayer, value);
		}

		[Ordinal(7)] 
		[RED("debugLayer")] 
		public inkDebugLayerDefinition DebugLayer
		{
			get => GetProperty(ref _debugLayer);
			set => SetProperty(ref _debugLayer, value);
		}
	}
}
