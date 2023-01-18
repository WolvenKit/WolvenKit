using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BuildBluelinePart : gameinteractionsvisBluelinePart
	{
		[Ordinal(2)] 
		[RED("record")] 
		public CHandle<gamedataPlayerBuild_Record> Record
		{
			get => GetPropertyValue<CHandle<gamedataPlayerBuild_Record>>();
			set => SetPropertyValue<CHandle<gamedataPlayerBuild_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("lhsValue")] 
		public CInt32 LhsValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("rhsValue")] 
		public CInt32 RhsValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("comparisonOperator")] 
		public CEnum<ECompareOp> ComparisonOperator
		{
			get => GetPropertyValue<CEnum<ECompareOp>>();
			set => SetPropertyValue<CEnum<ECompareOp>>(value);
		}

		public BuildBluelinePart()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
