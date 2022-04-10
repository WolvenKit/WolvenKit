using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class textWrappingInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("autoWrappingEnabled")] 
		public CBool AutoWrappingEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("wrappingAtPosition")] 
		public CFloat WrappingAtPosition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("wrappingPolicy")] 
		public CEnum<textWrappingPolicy> WrappingPolicy
		{
			get => GetPropertyValue<CEnum<textWrappingPolicy>>();
			set => SetPropertyValue<CEnum<textWrappingPolicy>>(value);
		}

		public textWrappingInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
