using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questComparisonParam : ISerializable
	{
		[Ordinal(0)] 
		[RED("entireCommunity")] 
		public CBool EntireCommunity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		public questComparisonParam()
		{
			EntireCommunity = true;
			ComparisonType = Enums.EComparisonType.Equal;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
