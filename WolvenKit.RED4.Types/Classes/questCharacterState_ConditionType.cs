using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterState_ConditionType : questICharacterConditionType
	{
		private CHandle<questICharacterConditionSubType> _subType;

		[Ordinal(0)] 
		[RED("subType")] 
		public CHandle<questICharacterConditionSubType> SubType
		{
			get => GetProperty(ref _subType);
			set => SetProperty(ref _subType, value);
		}
	}
}
