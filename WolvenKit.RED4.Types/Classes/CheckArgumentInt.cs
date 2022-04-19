using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckArgumentInt : CheckArguments
	{
		[Ordinal(1)] 
		[RED("customVar")] 
		public CInt32 CustomVar
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("comparator")] 
		public CEnum<ECompareOp> Comparator
		{
			get => GetPropertyValue<CEnum<ECompareOp>>();
			set => SetPropertyValue<CEnum<ECompareOp>>(value);
		}

		public CheckArgumentInt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
