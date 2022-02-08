using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SuppressSecuritySystemStateChange : redEvent
	{
		[Ordinal(0)] 
		[RED("forceSecuritySystemIntoStrictQuestControl")] 
		public CBool ForceSecuritySystemIntoStrictQuestControl
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
