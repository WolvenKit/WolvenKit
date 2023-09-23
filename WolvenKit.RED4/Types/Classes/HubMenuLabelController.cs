using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HubMenuLabelController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("wrapper")] 
		public CWeakHandle<inkWidget> Wrapper
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("wrapperNext")] 
		public CWeakHandle<inkWidget> WrapperNext
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("wrapperController")] 
		public CWeakHandle<HubMenuLabelContentContainer> WrapperController
		{
			get => GetPropertyValue<CWeakHandle<HubMenuLabelContentContainer>>();
			set => SetPropertyValue<CWeakHandle<HubMenuLabelContentContainer>>(value);
		}

		[Ordinal(5)] 
		[RED("wrapperNextController")] 
		public CWeakHandle<HubMenuLabelContentContainer> WrapperNextController
		{
			get => GetPropertyValue<CWeakHandle<HubMenuLabelContentContainer>>();
			set => SetPropertyValue<CWeakHandle<HubMenuLabelContentContainer>>(value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public MenuData Data
		{
			get => GetPropertyValue<MenuData>();
			set => SetPropertyValue<MenuData>(value);
		}

		[Ordinal(7)] 
		[RED("watchForSize")] 
		public CBool WatchForSize
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("watchForInstatnSize")] 
		public CBool WatchForInstatnSize
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("once")] 
		public CBool Once
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("direction")] 
		public CInt32 Direction
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("isRadialVariant")] 
		public CBool IsRadialVariant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HubMenuLabelController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
