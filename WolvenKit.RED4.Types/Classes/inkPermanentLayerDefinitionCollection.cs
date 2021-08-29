using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPermanentLayerDefinitionCollection : RedBaseClass
	{
		private inkLoadingLayerDefinition _loadingLayer;
		private inkWatermarksLayerDefinition _watermarksLayer;
		private inkSystemNotificationsLayerDefinition _sysNotificationsLayer;
		private inkWaitingSignLayerDefinition _waitingSignLayerDefinition;

		[Ordinal(0)] 
		[RED("loadingLayer")] 
		public inkLoadingLayerDefinition LoadingLayer
		{
			get => GetProperty(ref _loadingLayer);
			set => SetProperty(ref _loadingLayer, value);
		}

		[Ordinal(1)] 
		[RED("watermarksLayer")] 
		public inkWatermarksLayerDefinition WatermarksLayer
		{
			get => GetProperty(ref _watermarksLayer);
			set => SetProperty(ref _watermarksLayer, value);
		}

		[Ordinal(2)] 
		[RED("sysNotificationsLayer")] 
		public inkSystemNotificationsLayerDefinition SysNotificationsLayer
		{
			get => GetProperty(ref _sysNotificationsLayer);
			set => SetProperty(ref _sysNotificationsLayer, value);
		}

		[Ordinal(3)] 
		[RED("waitingSignLayerDefinition")] 
		public inkWaitingSignLayerDefinition WaitingSignLayerDefinition
		{
			get => GetProperty(ref _waitingSignLayerDefinition);
			set => SetProperty(ref _waitingSignLayerDefinition, value);
		}
	}
}
