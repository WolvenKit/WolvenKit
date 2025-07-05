using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeTankScoreMultiplierHUDController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("scoreMultiplierBarFill")] 
		public inkImageWidgetReference ScoreMultiplierBarFill
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public gameuiarcadeTankScoreMultiplierHUDController()
		{
			ScoreMultiplierBarFill = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
