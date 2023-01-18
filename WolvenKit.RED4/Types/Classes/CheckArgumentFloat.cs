using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckArgumentFloat : CheckArguments
	{
		[Ordinal(1)] 
		[RED("customVar")] 
		public CFloat CustomVar
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("comparator")] 
		public CEnum<ECompareOp> Comparator
		{
			get => GetPropertyValue<CEnum<ECompareOp>>();
			set => SetPropertyValue<CEnum<ECompareOp>>(value);
		}

		public CheckArgumentFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
