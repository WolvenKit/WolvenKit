using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questOpenBriefing_NodeType : questIUIManagerNodeType
	{
		private CHandle<gameJournalPath> _briefingPath;

		[Ordinal(0)] 
		[RED("briefingPath")] 
		public CHandle<gameJournalPath> BriefingPath
		{
			get => GetProperty(ref _briefingPath);
			set => SetProperty(ref _briefingPath, value);
		}
	}
}
