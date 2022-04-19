using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterGroupAttitude_CondtionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("group1Name")] 
		public CName Group1Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("group2Name")] 
		public CName Group2Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetPropertyValue<CEnum<EAIAttitude>>();
			set => SetPropertyValue<CEnum<EAIAttitude>>(value);
		}

		public questCharacterGroupAttitude_CondtionType()
		{
			Attitude = Enums.EAIAttitude.AIA_Neutral;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
