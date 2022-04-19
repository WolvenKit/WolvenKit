using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDesiredSlotsCountInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("siredSlotsCount")] 
		public CFloat SiredSlotsCount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("nCoeff")] 
		public CFloat NCoeff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldDesiredSlotsCountInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
