using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickHackToggleON : ActionBool
	{
		[Ordinal(38)] 
		[RED("Repeat")] 
		public CBool Repeat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickHackToggleON()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
