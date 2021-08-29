using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetSecuritySystemState : redEvent
	{
		private CEnum<ESecuritySystemState> _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<ESecuritySystemState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
