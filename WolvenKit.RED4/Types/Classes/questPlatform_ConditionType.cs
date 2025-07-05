using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlatform_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("platform")] 
		public CEnum<questPlatform> Platform
		{
			get => GetPropertyValue<CEnum<questPlatform>>();
			set => SetPropertyValue<CEnum<questPlatform>>(value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questPlatform_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
