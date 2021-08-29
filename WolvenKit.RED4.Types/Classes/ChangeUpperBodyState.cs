using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeUpperBodyState : ChangeUpperBodyStateAbstract
	{
		private CEnum<gamedataNPCUpperBodyState> _newState;

		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<gamedataNPCUpperBodyState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}
	}
}
