using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiInteractionMappinController : gameuiMappinBaseController
	{
		[Ordinal(7)] 
		[RED("isCurrentlyClamped")] 
		public CBool IsCurrentlyClamped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("isUnderCrosshair")] 
		public CBool IsUnderCrosshair
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("canvasWidgetName")] 
		public CName CanvasWidgetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("arrowWidgetName")] 
		public CName ArrowWidgetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiInteractionMappinController()
		{
			IconWidget = new();
			PlayerTrackedWidget = new();
			ScaleWidget = new();
			AnimPlayerTrackedWidget = new();
			AnimPlayerAboveBelowWidget = new();
			TaggedWidgets = new();
			CanvasWidgetName = "Canvas";
			ArrowWidgetName = "Arrow";
		}
	}
}
