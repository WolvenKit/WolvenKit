using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterCollisionController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("explosionPlatformDelay")] 
		public CFloat ExplosionPlatformDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("respawnPlatformDetails")] 
		public CArray<gameuiarcadeShooterExplodingPlatformSpawnDetail> RespawnPlatformDetails
		{
			get => GetPropertyValue<CArray<gameuiarcadeShooterExplodingPlatformSpawnDetail>>();
			set => SetPropertyValue<CArray<gameuiarcadeShooterExplodingPlatformSpawnDetail>>(value);
		}

		public gameuiarcadeShooterCollisionController()
		{
			RespawnPlatformDetails = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
