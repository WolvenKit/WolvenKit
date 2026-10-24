using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioReportReasonButtonController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("buttonCore")] 
		public inkWidgetReference ButtonCore
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("buttonBorder")] 
		public inkWidgetReference ButtonBorder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("leftButtonSideBorder")] 
		public inkWidgetReference LeftButtonSideBorder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		public ModioReportReasonButtonController()
		{
			ButtonCore = new inkWidgetReference();
			ButtonBorder = new inkWidgetReference();
			LeftButtonSideBorder = new inkWidgetReference();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
