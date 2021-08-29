using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetBriefingSize_NodeType : questIUIManagerNodeType
	{
		private CEnum<questJournalSizeEventType> _briefingSize;

		[Ordinal(0)] 
		[RED("briefingSize")] 
		public CEnum<questJournalSizeEventType> BriefingSize
		{
			get => GetProperty(ref _briefingSize);
			set => SetProperty(ref _briefingSize, value);
		}
	}
}
