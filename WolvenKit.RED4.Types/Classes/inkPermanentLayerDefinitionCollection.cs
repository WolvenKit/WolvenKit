using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkPermanentLayerDefinitionCollection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("loadingLayer")] 
		public inkLoadingLayerDefinition LoadingLayer
		{
			get => GetPropertyValue<inkLoadingLayerDefinition>();
			set => SetPropertyValue<inkLoadingLayerDefinition>(value);
		}

		[Ordinal(1)] 
		[RED("watermarksLayer")] 
		public inkWatermarksLayerDefinition WatermarksLayer
		{
			get => GetPropertyValue<inkWatermarksLayerDefinition>();
			set => SetPropertyValue<inkWatermarksLayerDefinition>(value);
		}

		[Ordinal(2)] 
		[RED("sysNotificationsLayer")] 
		public inkSystemNotificationsLayerDefinition SysNotificationsLayer
		{
			get => GetPropertyValue<inkSystemNotificationsLayerDefinition>();
			set => SetPropertyValue<inkSystemNotificationsLayerDefinition>(value);
		}

		[Ordinal(3)] 
		[RED("waitingSignLayerDefinition")] 
		public inkWaitingSignLayerDefinition WaitingSignLayerDefinition
		{
			get => GetPropertyValue<inkWaitingSignLayerDefinition>();
			set => SetPropertyValue<inkWaitingSignLayerDefinition>(value);
		}

		public inkPermanentLayerDefinitionCollection()
		{
			LoadingLayer = new();
			WatermarksLayer = new();
			SysNotificationsLayer = new();
			WaitingSignLayerDefinition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
