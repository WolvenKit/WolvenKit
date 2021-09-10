using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UsingCoverPSMPrereqState : PlayerStateMachinePrereqState
	{
		[Ordinal(3)] 
		[RED("bValue")] 
		public CBool BValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
