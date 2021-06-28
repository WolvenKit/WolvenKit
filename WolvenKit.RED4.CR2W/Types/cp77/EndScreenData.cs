using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EndScreenData : CVariable
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

		public EndScreenData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
