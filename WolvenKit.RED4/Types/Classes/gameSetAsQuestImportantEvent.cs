using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetAsQuestImportantEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isImportant")] 
		public CBool IsImportant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("propagateToSlaves")] 
		public CBool PropagateToSlaves
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSetAsQuestImportantEvent()
		{
			IsImportant = true;
			PropagateToSlaves = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
