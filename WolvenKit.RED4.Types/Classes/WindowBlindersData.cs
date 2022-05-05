using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WindowBlindersData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("windowBlindersState")] 
		public CEnum<EWindowBlindersStates> WindowBlindersState
		{
			get => GetPropertyValue<CEnum<EWindowBlindersStates>>();
			set => SetPropertyValue<CEnum<EWindowBlindersStates>>(value);
		}

		[Ordinal(1)] 
		[RED("hasOpenInteraction")] 
		public CBool HasOpenInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("hasTiltInteraction")] 
		public CBool HasTiltInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("hasQuickHack")] 
		public CBool HasQuickHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WindowBlindersData()
		{
			WindowBlindersState = Enums.EWindowBlindersStates.Closed;
			HasOpenInteraction = true;
			HasQuickHack = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
