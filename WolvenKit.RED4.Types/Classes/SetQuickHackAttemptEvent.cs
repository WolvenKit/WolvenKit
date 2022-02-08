using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetQuickHackAttemptEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("wasQuickHackAttempt")] 
		public CBool WasQuickHackAttempt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
