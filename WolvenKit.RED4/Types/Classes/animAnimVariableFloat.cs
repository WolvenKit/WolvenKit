using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimVariableFloat : animAnimVariable
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("default")] 
		public CFloat Default
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimVariableFloat()
		{
			Min = -16.000000F;
			Max = 16.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
