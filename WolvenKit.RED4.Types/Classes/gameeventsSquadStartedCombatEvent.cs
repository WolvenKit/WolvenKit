using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsSquadStartedCombatEvent : redEvent
	{
		private CBool _started;

		[Ordinal(0)] 
		[RED("started")] 
		public CBool Started
		{
			get => GetProperty(ref _started);
			set => SetProperty(ref _started, value);
		}
	}
}
