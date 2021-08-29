using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetBriefingAlignment_NodeType : questIUIManagerNodeType
	{
		private CEnum<questJournalAlignmentEventType> _briefingAlignment;

		[Ordinal(0)] 
		[RED("briefingAlignment")] 
		public CEnum<questJournalAlignmentEventType> BriefingAlignment
		{
			get => GetProperty(ref _briefingAlignment);
			set => SetProperty(ref _briefingAlignment, value);
		}
	}
}
