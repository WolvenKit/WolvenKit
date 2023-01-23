using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleQuestCrystalDomeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("removeQuestControl")] 
		public CBool RemoveQuestControl
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleQuestCrystalDomeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
