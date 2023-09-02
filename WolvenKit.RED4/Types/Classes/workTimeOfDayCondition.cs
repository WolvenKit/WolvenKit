using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workTimeOfDayCondition : workIWorkspotCondition
	{
		[Ordinal(2)] 
		[RED("activeAfter")] 
		public GameTime ActiveAfter
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(3)] 
		[RED("activeUntil")] 
		public GameTime ActiveUntil
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		public workTimeOfDayCondition()
		{
			Equals_ = true;
			ActiveAfter = new GameTime();
			ActiveUntil = new GameTime();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
