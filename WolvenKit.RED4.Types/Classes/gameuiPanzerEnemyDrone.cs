using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPanzerEnemyDrone : gameuiPanzerEnemy
	{
		[Ordinal(16)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("shootIntervalMinimum")] 
		public CFloat ShootIntervalMinimum
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("shootIntervalMaximum")] 
		public CFloat ShootIntervalMaximum
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiPanzerEnemyDrone()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
