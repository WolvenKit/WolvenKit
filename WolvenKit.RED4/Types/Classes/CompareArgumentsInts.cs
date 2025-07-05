using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CompareArgumentsInts : CompareArguments
	{
		[Ordinal(2)] 
		[RED("comparator")] 
		public CEnum<ECompareOp> Comparator
		{
			get => GetPropertyValue<CEnum<ECompareOp>>();
			set => SetPropertyValue<CEnum<ECompareOp>>(value);
		}

		public CompareArgumentsInts()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
