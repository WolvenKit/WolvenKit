using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimEvent_FootPhase : animAnimEvent
	{
		private CEnum<animEFootPhase> _phase;

		[Ordinal(3)] 
		[RED("phase")] 
		public CEnum<animEFootPhase> Phase
		{
			get => GetProperty(ref _phase);
			set => SetProperty(ref _phase, value);
		}
	}
}
