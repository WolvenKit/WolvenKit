using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questContentToken_ConditionType : questIContentConditionType
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questQuestContentType> Type
		{
			get => GetPropertyValue<CEnum<questQuestContentType>>();
			set => SetPropertyValue<CEnum<questQuestContentType>>(value);
		}

		public questContentToken_ConditionType()
		{
			Type = Enums.questQuestContentType.MainQuest;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
