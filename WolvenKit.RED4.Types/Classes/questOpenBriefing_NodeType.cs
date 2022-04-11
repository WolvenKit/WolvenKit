using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questOpenBriefing_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("briefingPath")] 
		public CHandle<gameJournalPath> BriefingPath
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}
	}
}
