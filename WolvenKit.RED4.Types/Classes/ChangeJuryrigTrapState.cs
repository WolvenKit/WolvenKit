using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeJuryrigTrapState : redEvent
	{
		private CEnum<EJuryrigTrapState> _newState;

		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<EJuryrigTrapState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}
	}
}
