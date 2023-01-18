using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPhoneMuted_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("groupName")] 
		public CName GroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questPhoneMuted_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
