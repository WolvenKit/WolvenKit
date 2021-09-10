using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsSquadStartedCombatEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("started")] 
		public CBool Started
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
