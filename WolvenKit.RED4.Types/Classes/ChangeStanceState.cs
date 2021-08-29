using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeStanceState : ChangeStanceStateAbstract
	{
		private CEnum<gamedataNPCStanceState> _newState;

		[Ordinal(1)] 
		[RED("newState")] 
		public CEnum<gamedataNPCStanceState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}
	}
}
