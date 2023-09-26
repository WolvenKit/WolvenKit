using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreOrderPopupController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("preOrderButtonRef")] 
		public inkWidgetReference PreOrderButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("preOrderButtonText")] 
		public inkTextWidgetReference PreOrderButtonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("preOrderButtonInputIcon")] 
		public inkWidgetReference PreOrderButtonInputIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("releaseDateContainer")] 
		public inkWidgetReference ReleaseDateContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("buttonController")] 
		public CWeakHandle<inkButtonController> ButtonController
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		public PreOrderPopupController()
		{
			PreOrderButtonRef = new inkWidgetReference();
			PreOrderButtonText = new inkTextWidgetReference();
			PreOrderButtonInputIcon = new inkWidgetReference();
			ReleaseDateContainer = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
