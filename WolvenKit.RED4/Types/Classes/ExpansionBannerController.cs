using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExpansionBannerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("statusTextRef")] 
		public inkTextWidgetReference StatusTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("bottomPanelRef")] 
		public inkWidgetReference BottomPanelRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("inputHintRef")] 
		public inkWidgetReference InputHintRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("indicatorRef")] 
		public inkWidgetReference IndicatorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("errorPanelRef")] 
		public inkWidgetReference ErrorPanelRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("errorIconRef")] 
		public inkWidgetReference ErrorIconRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("expansionStatus")] 
		public CEnum<ExpansionStatus> ExpansionStatus
		{
			get => GetPropertyValue<CEnum<ExpansionStatus>>();
			set => SetPropertyValue<CEnum<ExpansionStatus>>(value);
		}

		[Ordinal(8)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public ExpansionBannerController()
		{
			StatusTextRef = new();
			BottomPanelRef = new();
			InputHintRef = new();
			IndicatorRef = new();
			ErrorPanelRef = new();
			ErrorIconRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
