using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickHackLockHacks : redEvent
	{
		[Ordinal(0)] 
		[RED("IsLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickHackLockHacks()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
