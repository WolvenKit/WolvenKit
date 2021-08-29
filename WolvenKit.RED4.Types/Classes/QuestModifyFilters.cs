using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestModifyFilters : redEvent
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
	}
}
