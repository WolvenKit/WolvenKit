using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeRoachRaceObstacleController : gameuiarcadeArcadeObjectController
	{
		[Ordinal(2)] 
		[RED("collider")] 
		public gameuiarcadeBoundingRect Collider
		{
			get => GetPropertyValue<gameuiarcadeBoundingRect>();
			set => SetPropertyValue<gameuiarcadeBoundingRect>(value);
		}

		public gameuiarcadeRoachRaceObstacleController()
		{
			Collider = new gameuiarcadeBoundingRect();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
