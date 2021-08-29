using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterState_PuppetSubType : questICharacterConditionSubType
	{
		private gameEntityReference _puppetRef;
		private CEnum<questEComparisonTypeEquality> _upperBodyComparisonType;
		private CInt32 _upperBodyState;
		private CEnum<questEComparisonTypeEquality> _highLevelComparisonType;
		private CInt32 _highLevelState;
		private CEnum<questEComparisonTypeEquality> _stanceComparisonType;
		private CInt32 _stanceState;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("upperBodyComparisonType")] 
		public CEnum<questEComparisonTypeEquality> UpperBodyComparisonType
		{
			get => GetProperty(ref _upperBodyComparisonType);
			set => SetProperty(ref _upperBodyComparisonType, value);
		}

		[Ordinal(2)] 
		[RED("upperBodyState")] 
		public CInt32 UpperBodyState
		{
			get => GetProperty(ref _upperBodyState);
			set => SetProperty(ref _upperBodyState, value);
		}

		[Ordinal(3)] 
		[RED("highLevelComparisonType")] 
		public CEnum<questEComparisonTypeEquality> HighLevelComparisonType
		{
			get => GetProperty(ref _highLevelComparisonType);
			set => SetProperty(ref _highLevelComparisonType, value);
		}

		[Ordinal(4)] 
		[RED("highLevelState")] 
		public CInt32 HighLevelState
		{
			get => GetProperty(ref _highLevelState);
			set => SetProperty(ref _highLevelState, value);
		}

		[Ordinal(5)] 
		[RED("stanceComparisonType")] 
		public CEnum<questEComparisonTypeEquality> StanceComparisonType
		{
			get => GetProperty(ref _stanceComparisonType);
			set => SetProperty(ref _stanceComparisonType, value);
		}

		[Ordinal(6)] 
		[RED("stanceState")] 
		public CInt32 StanceState
		{
			get => GetProperty(ref _stanceState);
			set => SetProperty(ref _stanceState, value);
		}
	}
}
