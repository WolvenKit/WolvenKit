using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EndScreenData : RedBaseClass
	{
		private CArray<ProgramData> _unlockedPrograms;
		private CEnum<OutcomeMessage> _outcome;

		[Ordinal(0)] 
		[RED("unlockedPrograms")] 
		public CArray<ProgramData> UnlockedPrograms
		{
			get => GetProperty(ref _unlockedPrograms);
			set => SetProperty(ref _unlockedPrograms, value);
		}

		[Ordinal(1)] 
		[RED("outcome")] 
		public CEnum<OutcomeMessage> Outcome
		{
			get => GetProperty(ref _outcome);
			set => SetProperty(ref _outcome, value);
		}
	}
}
