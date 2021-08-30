using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entFootPhaseChangedEvent : redEvent
	{
		private CEnum<animEFootPhase> _footPhase;

		[Ordinal(0)] 
		[RED("footPhase")] 
		public CEnum<animEFootPhase> FootPhase
		{
			get => GetProperty(ref _footPhase);
			set => SetProperty(ref _footPhase, value);
		}

		public entFootPhaseChangedEvent()
		{
			_footPhase = new() { Value = Enums.animEFootPhase.NotConsidered };
		}
	}
}
