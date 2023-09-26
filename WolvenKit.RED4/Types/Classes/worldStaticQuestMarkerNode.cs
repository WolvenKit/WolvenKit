using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticQuestMarkerNode : worldNode
	{
		[Ordinal(4)] 
		[RED("questType")] 
		public CEnum<worldQuestType> QuestType
		{
			get => GetPropertyValue<CEnum<worldQuestType>>();
			set => SetPropertyValue<CEnum<worldQuestType>>(value);
		}

		[Ordinal(5)] 
		[RED("questLabel")] 
		public CString QuestLabel
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("mapFilteringTag")] 
		public CName MapFilteringTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("questMarkerHeight")] 
		public CFloat QuestMarkerHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldStaticQuestMarkerNode()
		{
			QuestLabel = "Temporary Quest Label";
			QuestMarkerHeight = 500.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
