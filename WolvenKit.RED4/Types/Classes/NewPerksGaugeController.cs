using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksGaugeController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("possibleBar")] 
		public inkWidgetReference PossibleBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("currentLevelIndicator")] 
		public inkWidgetReference CurrentLevelIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("possibleLevelIndicator")] 
		public inkWidgetReference PossibleLevelIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("levels")] 
		public CArray<NewPerksGaugePointDetails> Levels
		{
			get => GetPropertyValue<CArray<NewPerksGaugePointDetails>>();
			set => SetPropertyValue<CArray<NewPerksGaugePointDetails>>(value);
		}

		public NewPerksGaugeController()
		{
			Bar = new inkWidgetReference();
			PossibleBar = new inkWidgetReference();
			CurrentLevelIndicator = new inkWidgetReference();
			PossibleLevelIndicator = new inkWidgetReference();
			LevelText = new inkTextWidgetReference();
			Levels = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
