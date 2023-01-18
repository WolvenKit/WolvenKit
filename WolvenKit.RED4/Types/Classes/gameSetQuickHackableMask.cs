using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetQuickHackableMask : redEvent
	{
		[Ordinal(0)] 
		[RED("isQuickHackable")] 
		public CBool IsQuickHackable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSetQuickHackableMask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
