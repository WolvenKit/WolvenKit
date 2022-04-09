using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetBriefingAlignment_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("briefingAlignment")] 
		public CEnum<questJournalAlignmentEventType> BriefingAlignment
		{
			get => GetPropertyValue<CEnum<questJournalAlignmentEventType>>();
			set => SetPropertyValue<CEnum<questJournalAlignmentEventType>>(value);
		}

		public questSetBriefingAlignment_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
