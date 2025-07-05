using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldRaceSplineNodeOffset : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("from")] 
		public CFloat From
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("to")] 
		public CFloat To
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("left")] 
		public CFloat Left
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("right")] 
		public CFloat Right
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldRaceSplineNodeOffset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
