using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IsPlayerMovingPrereqState : PlayerStateMachinePrereqState
	{
		private CBool _bbValue;

		[Ordinal(3)] 
		[RED("bbValue")] 
		public CBool BbValue
		{
			get => GetProperty(ref _bbValue);
			set => SetProperty(ref _bbValue, value);
		}
	}
}
