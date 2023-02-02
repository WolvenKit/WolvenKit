using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSpeedSplineNodeSpeedRestriction : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("from")] 
		public CFloat From
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("adjustTime")] 
		public CFloat AdjustTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldSpeedSplineNodeSpeedRestriction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
