using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalRequestContext : CVariable
	{
		private gameJournalRequestStateFilter _stateFilter;
		private gameJournalRequestClassFilter _classFilter;

		[Ordinal(0)] 
		[RED("stateFilter")] 
		public gameJournalRequestStateFilter StateFilter
		{
			get => GetProperty(ref _stateFilter);
			set => SetProperty(ref _stateFilter, value);
		}

		[Ordinal(1)] 
		[RED("classFilter")] 
		public gameJournalRequestClassFilter ClassFilter
		{
			get => GetProperty(ref _classFilter);
			set => SetProperty(ref _classFilter, value);
		}

		public gameJournalRequestContext(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
