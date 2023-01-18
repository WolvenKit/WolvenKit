using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterSpawned_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("comparisonParams")] 
		public CHandle<questComparisonParam> ComparisonParams
		{
			get => GetPropertyValue<CHandle<questComparisonParam>>();
			set => SetPropertyValue<CHandle<questComparisonParam>>(value);
		}

		public questCharacterSpawned_ConditionType()
		{
			ObjectRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
