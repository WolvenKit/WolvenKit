using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SNameplateRangesData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("c_DisplayRange")] 
		public CFloat C_DisplayRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("c_MaxDisplayRange")] 
		public CFloat C_MaxDisplayRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("c_MaxDisplayRangeNotAggressive")] 
		public CFloat C_MaxDisplayRangeNotAggressive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("c_DisplayRangeNotAggressive")] 
		public CFloat C_DisplayRangeNotAggressive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SNameplateRangesData()
		{
			C_DisplayRange = 35.000000F;
			C_MaxDisplayRange = 50.000000F;
			C_MaxDisplayRangeNotAggressive = 10.000000F;
			C_DisplayRangeNotAggressive = 3.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
