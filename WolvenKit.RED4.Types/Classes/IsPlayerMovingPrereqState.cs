using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsPlayerMovingPrereqState : PlayerStateMachinePrereqState
	{
		[Ordinal(3)] 
		[RED("bbValue")] 
		public CBool BbValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
