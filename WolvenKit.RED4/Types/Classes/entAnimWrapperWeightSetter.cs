using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimWrapperWeightSetter : entAnimInputSetter
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entAnimWrapperWeightSetter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
