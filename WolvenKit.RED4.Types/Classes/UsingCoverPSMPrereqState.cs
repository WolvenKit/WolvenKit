using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UsingCoverPSMPrereqState : PlayerStateMachinePrereqState
	{
		private CBool _bValue;

		[Ordinal(3)] 
		[RED("bValue")] 
		public CBool BValue
		{
			get => GetProperty(ref _bValue);
			set => SetProperty(ref _bValue, value);
		}
	}
}
