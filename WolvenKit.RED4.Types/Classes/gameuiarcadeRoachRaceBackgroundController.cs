using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeRoachRaceBackgroundController : gameuiarcadeArcadeBackgroundController
	{
		[Ordinal(2)] 
		[RED("parallaxPlaneRelativeVelocityList")] 
		public CArray<CFloat> ParallaxPlaneRelativeVelocityList
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("daynightWidget")] 
		public inkWidgetReference DaynightWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("backgroundObjectSpawner")] 
		public inkWidgetReference BackgroundObjectSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("cloudSpawner")] 
		public inkWidgetReference CloudSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeRoachRaceBackgroundController()
		{
			ParallaxPlaneRelativeVelocityList = new();
			DaynightWidget = new();
			BackgroundObjectSpawner = new();
			CloudSpawner = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
