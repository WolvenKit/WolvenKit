using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LoadGameMenuGameController : gameuiSaveHandlingController
	{
		[Ordinal(3)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("transitToLoadingAnimName")] 
		public CName TransitToLoadingAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("transitToLoadingSlotAnimName")] 
		public CName TransitToLoadingSlotAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("animDelayBetweenSlots")] 
		public CFloat AnimDelayBetweenSlots
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("animDelayForMainSlot")] 
		public CFloat AnimDelayForMainSlot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("enableLoadingTransition")] 
		public CBool EnableLoadingTransition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("eventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(11)] 
		[RED("loadComplete")] 
		public CBool LoadComplete
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("saveInfo")] 
		public CHandle<inkSaveMetadataInfo> SaveInfo
		{
			get => GetPropertyValue<CHandle<inkSaveMetadataInfo>>();
			set => SetPropertyValue<CHandle<inkSaveMetadataInfo>>(value);
		}

		[Ordinal(13)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(14)] 
		[RED("saveToLoadIndex")] 
		public CInt32 SaveToLoadIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("isInputDisabled")] 
		public CBool IsInputDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LoadGameMenuGameController()
		{
			List = new();
			ButtonHintsManagerRef = new();
		}
	}
}
