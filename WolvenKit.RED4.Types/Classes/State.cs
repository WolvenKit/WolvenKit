using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class State : MorphData
	{
		private CEnum<ESecuritySystemState> _state;

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<ESecuritySystemState> State_
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
