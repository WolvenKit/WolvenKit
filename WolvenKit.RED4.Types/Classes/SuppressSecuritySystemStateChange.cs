using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SuppressSecuritySystemStateChange : redEvent
	{
		private CBool _forceSecuritySystemIntoStrictQuestControl;

		[Ordinal(0)] 
		[RED("forceSecuritySystemIntoStrictQuestControl")] 
		public CBool ForceSecuritySystemIntoStrictQuestControl
		{
			get => GetProperty(ref _forceSecuritySystemIntoStrictQuestControl);
			set => SetProperty(ref _forceSecuritySystemIntoStrictQuestControl, value);
		}
	}
}
