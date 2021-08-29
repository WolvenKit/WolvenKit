using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterCondition : questTypedCondition
	{
		private CHandle<questICharacterConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questICharacterConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
