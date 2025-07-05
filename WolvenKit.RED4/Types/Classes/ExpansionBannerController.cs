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
		[RED("inputHintRef")] 
		public inkWidgetReference InputHintRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("indicatorRef")] 
		public inkWidgetReference IndicatorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("errorPanelRef")] 
		public inkWidgetReference ErrorPanelRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("errorIconRef")] 
		public inkWidgetReference ErrorIconRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("expansionStatus")] 
		public CEnum<ExpansionStatus> ExpansionStatus
		{
			get => GetPropertyValue<CEnum<ExpansionStatus>>();
			set => SetPropertyValue<CEnum<ExpansionStatus>>(value);
		}

		[Ordinal(7)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public ExpansionBannerController()
		{
			StatusTextRef = new inkTextWidgetReference();
			InputHintRef = new inkWidgetReference();
			IndicatorRef = new inkWidgetReference();
			ErrorPanelRef = new inkWidgetReference();
			ErrorIconRef = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
