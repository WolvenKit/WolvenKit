using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetPhaseState : AIActionHelperTask
	{
		private CEnum<ENPCPhaseState> _phaseStateValue;

		[Ordinal(5)] 
		[RED("phaseStateValue")] 
		public CEnum<ENPCPhaseState> PhaseStateValue
		{
			get => GetProperty(ref _phaseStateValue);
			set => SetProperty(ref _phaseStateValue, value);
		}
	}
}
