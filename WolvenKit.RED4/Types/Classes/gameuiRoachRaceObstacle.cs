using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRoachRaceObstacle : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("dynObjectType")] 
		public CName DynObjectType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiRoachRaceObstacle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
