using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReactoToPreventionSystem : redEvent
	{
		[Ordinal(0)] 
		[RED("wakeUp")] 
		public CBool WakeUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
