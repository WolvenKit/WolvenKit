using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameRange : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("minValue")] 
		public CFloat MinValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameRange()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
