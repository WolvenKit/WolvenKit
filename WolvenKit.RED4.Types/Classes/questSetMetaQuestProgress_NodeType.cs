using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetMetaQuestProgress_NodeType : questIUIManagerNodeType
	{
		private CEnum<gamedataMetaQuest> _metaQuestId;
		private CUInt32 _percent;
		private LocalizationString _text;

		[Ordinal(0)] 
		[RED("metaQuestId")] 
		public CEnum<gamedataMetaQuest> MetaQuestId
		{
			get => GetProperty(ref _metaQuestId);
			set => SetProperty(ref _metaQuestId, value);
		}

		[Ordinal(1)] 
		[RED("percent")] 
		public CUInt32 Percent
		{
			get => GetProperty(ref _percent);
			set => SetProperty(ref _percent, value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}
	}
}
