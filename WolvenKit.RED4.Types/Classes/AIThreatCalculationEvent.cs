using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIThreatCalculationEvent : redEvent
	{
		private CBool _set;
		private CEnum<EAIThreatCalculationType> _temporaryThreatCalculationType;

		[Ordinal(0)] 
		[RED("set")] 
		public CBool Set
		{
			get => GetProperty(ref _set);
			set => SetProperty(ref _set, value);
		}

		[Ordinal(1)] 
		[RED("temporaryThreatCalculationType")] 
		public CEnum<EAIThreatCalculationType> TemporaryThreatCalculationType
		{
			get => GetProperty(ref _temporaryThreatCalculationType);
			set => SetProperty(ref _temporaryThreatCalculationType, value);
		}
	}
}
