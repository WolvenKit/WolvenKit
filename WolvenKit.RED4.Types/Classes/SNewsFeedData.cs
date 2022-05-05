using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SNewsFeedData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("elements")] 
		public CArray<SNewsFeedElementData> Elements
		{
			get => GetPropertyValue<CArray<SNewsFeedElementData>>();
			set => SetPropertyValue<CArray<SNewsFeedElementData>>(value);
		}

		public SNewsFeedData()
		{
			Interval = 5.000000F;
			Elements = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
