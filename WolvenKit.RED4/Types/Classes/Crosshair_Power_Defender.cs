using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Crosshair_Power_Defender : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("topPart")] 
		public inkWidgetReference TopPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("botPart")] 
		public inkWidgetReference BotPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public Crosshair_Power_Defender()
		{
			LeftPart = new();
			RightPart = new();
			TopPart = new();
			BotPart = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
