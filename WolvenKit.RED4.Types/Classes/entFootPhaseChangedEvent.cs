using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entFootPhaseChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("footPhase")] 
		public CEnum<animEFootPhase> FootPhase
		{
			get => GetPropertyValue<CEnum<animEFootPhase>>();
			set => SetPropertyValue<CEnum<animEFootPhase>>(value);
		}

		public entFootPhaseChangedEvent()
		{
			FootPhase = Enums.animEFootPhase.NotConsidered;
		}
	}
}
