using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gsmMainQuest : ISerializable
	{
		[Ordinal(0)] 
		[RED("questFile")] 
		public CResourceAsyncReference<questQuestResource> QuestFile
		{
			get => GetPropertyValue<CResourceAsyncReference<questQuestResource>>();
			set => SetPropertyValue<CResourceAsyncReference<questQuestResource>>(value);
		}

		[Ordinal(1)] 
		[RED("additionalContent")] 
		public CBool AdditionalContent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("additionalContentName")] 
		public CName AdditionalContentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gsmMainQuest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
