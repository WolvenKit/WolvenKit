using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetMetaQuestProgress_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("metaQuestId")] 
		public CEnum<gamedataMetaQuest> MetaQuestId
		{
			get => GetPropertyValue<CEnum<gamedataMetaQuest>>();
			set => SetPropertyValue<CEnum<gamedataMetaQuest>>(value);
		}

		[Ordinal(1)] 
		[RED("percent")] 
		public CUInt32 Percent
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public LocalizationString Text
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		public questSetMetaQuestProgress_NodeType()
		{
			Text = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
