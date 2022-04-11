using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questICharacterConditionType> Type
		{
			get => GetPropertyValue<CHandle<questICharacterConditionType>>();
			set => SetPropertyValue<CHandle<questICharacterConditionType>>(value);
		}
	}
}
