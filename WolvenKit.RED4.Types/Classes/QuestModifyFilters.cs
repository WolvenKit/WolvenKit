using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestModifyFilters : redEvent
	{
		[Ordinal(0)] 
		[RED("incomingFilters")] 
		public CEnum<EQuestFilterType> IncomingFilters
		{
			get => GetPropertyValue<CEnum<EQuestFilterType>>();
			set => SetPropertyValue<CEnum<EQuestFilterType>>(value);
		}

		[Ordinal(1)] 
		[RED("outgoingFilters")] 
		public CEnum<EQuestFilterType> OutgoingFilters
		{
			get => GetPropertyValue<CEnum<EQuestFilterType>>();
			set => SetPropertyValue<CEnum<EQuestFilterType>>(value);
		}
	}
}
