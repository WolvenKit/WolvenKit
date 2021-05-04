using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestModifyFilters : redEvent
	{
		private CEnum<EQuestFilterType> _incomingFilters;
		private CEnum<EQuestFilterType> _outgoingFilters;

		[Ordinal(0)] 
		[RED("incomingFilters")] 
		public CEnum<EQuestFilterType> IncomingFilters
		{
			get => GetProperty(ref _incomingFilters);
			set => SetProperty(ref _incomingFilters, value);
		}

		[Ordinal(1)] 
		[RED("outgoingFilters")] 
		public CEnum<EQuestFilterType> OutgoingFilters
		{
			get => GetProperty(ref _outgoingFilters);
			set => SetProperty(ref _outgoingFilters, value);
		}

		public QuestModifyFilters(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
