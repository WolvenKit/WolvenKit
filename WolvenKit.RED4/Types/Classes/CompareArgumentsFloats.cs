using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CompareArgumentsFloats : CompareArguments
	{
		[Ordinal(2)] 
		[RED("comparator")] 
		public CEnum<ECompareOp> Comparator
		{
			get => GetPropertyValue<CEnum<ECompareOp>>();
			set => SetPropertyValue<CEnum<ECompareOp>>(value);
		}

		public CompareArgumentsFloats()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
