using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetBriefingSize_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("briefingSize")] 
		public CEnum<questJournalSizeEventType> BriefingSize
		{
			get => GetPropertyValue<CEnum<questJournalSizeEventType>>();
			set => SetPropertyValue<CEnum<questJournalSizeEventType>>(value);
		}
	}
}
