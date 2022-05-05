using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterState_PuppetSubType : questICharacterConditionSubType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("upperBodyComparisonType")] 
		public CEnum<questEComparisonTypeEquality> UpperBodyComparisonType
		{
			get => GetPropertyValue<CEnum<questEComparisonTypeEquality>>();
			set => SetPropertyValue<CEnum<questEComparisonTypeEquality>>(value);
		}

		[Ordinal(2)] 
		[RED("upperBodyState")] 
		public CInt32 UpperBodyState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("highLevelComparisonType")] 
		public CEnum<questEComparisonTypeEquality> HighLevelComparisonType
		{
			get => GetPropertyValue<CEnum<questEComparisonTypeEquality>>();
			set => SetPropertyValue<CEnum<questEComparisonTypeEquality>>(value);
		}

		[Ordinal(4)] 
		[RED("highLevelState")] 
		public CInt32 HighLevelState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("stanceComparisonType")] 
		public CEnum<questEComparisonTypeEquality> StanceComparisonType
		{
			get => GetPropertyValue<CEnum<questEComparisonTypeEquality>>();
			set => SetPropertyValue<CEnum<questEComparisonTypeEquality>>(value);
		}

		[Ordinal(6)] 
		[RED("stanceState")] 
		public CInt32 StanceState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public questCharacterState_PuppetSubType()
		{
			PuppetRef = new() { Names = new() };
			UpperBodyState = 1;
			HighLevelState = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
