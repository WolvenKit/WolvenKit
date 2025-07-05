using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickHackMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("iconWidgetActive")] 
		public inkImageWidgetReference IconWidgetActive
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsIMappin> Mappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsIMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsIMappin>>(value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<GameplayRoleMappinData> Data
		{
			get => GetPropertyValue<CHandle<GameplayRoleMappinData>>();
			set => SetPropertyValue<CHandle<GameplayRoleMappinData>>(value);
		}

		[Ordinal(17)] 
		[RED("queueQuickHackWidgets")] 
		public CArray<inkWidgetReference> QueueQuickHackWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(18)] 
		[RED("queueQuickHackControllers")] 
		public CArray<CWeakHandle<QuickHackQueueItem>> QueueQuickHackControllers
		{
			get => GetPropertyValue<CArray<CWeakHandle<QuickHackQueueItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<QuickHackQueueItem>>>(value);
		}

		[Ordinal(19)] 
		[RED("mappinDataQueue")] 
		public CArray<CHandle<GameplayRoleMappinData>> MappinDataQueue
		{
			get => GetPropertyValue<CArray<CHandle<GameplayRoleMappinData>>>();
			set => SetPropertyValue<CArray<CHandle<GameplayRoleMappinData>>>(value);
		}

		[Ordinal(20)] 
		[RED("animUpload")] 
		public CHandle<inkanimProxy> AnimUpload
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(21)] 
		[RED("animQueue")] 
		public CHandle<inkanimProxy> AnimQueue
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public QuickHackMappinController()
		{
			Bar = new inkWidgetReference();
			Header = new inkTextWidgetReference();
			IconWidgetActive = new inkImageWidgetReference();
			QueueQuickHackWidgets = new();
			QueueQuickHackControllers = new();
			MappinDataQueue = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
