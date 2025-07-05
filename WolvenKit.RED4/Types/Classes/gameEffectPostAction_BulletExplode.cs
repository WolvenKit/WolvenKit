using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectPostAction_BulletExplode : gameEffectPostAction
	{
		[Ordinal(0)] 
		[RED("endRangeTolerance")] 
		public CFloat EndRangeTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("explosionDuration")] 
		public CFloat ExplosionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameEffectPostAction_BulletExplode()
		{
			EndRangeTolerance = 0.100000F;
			ExplosionDuration = 0.050000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
