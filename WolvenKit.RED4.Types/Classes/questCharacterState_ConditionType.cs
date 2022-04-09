using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterState_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("subType")] 
		public CHandle<questICharacterConditionSubType> SubType
		{
			get => GetPropertyValue<CHandle<questICharacterConditionSubType>>();
			set => SetPropertyValue<CHandle<questICharacterConditionSubType>>(value);
		}

		public questCharacterState_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
