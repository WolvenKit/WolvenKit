using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeArcadeMenuController : gameuiarcadeIArcadeScreenController
	{
		[Ordinal(1)] 
		[RED("startArrow")] 
		public inkWidgetReference StartArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("scoreboardArrow")] 
		public inkWidgetReference ScoreboardArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeArcadeMenuController()
		{
			StartArrow = new inkWidgetReference();
			ScoreboardArrow = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
