using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterState_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("subType")] 
		public CHandle<questICharacterConditionSubType> SubType
		{
			get => GetPropertyValue<CHandle<questICharacterConditionSubType>>();
			set => SetPropertyValue<CHandle<questICharacterConditionSubType>>(value);
		}
	}
}
