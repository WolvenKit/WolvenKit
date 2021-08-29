using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPanzerEnemyDrone : gameuiPanzerEnemy
	{
		private CFloat _speed;
		private CFloat _shootIntervalMinimum;
		private CFloat _shootIntervalMaximum;

		[Ordinal(16)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(17)] 
		[RED("shootIntervalMinimum")] 
		public CFloat ShootIntervalMinimum
		{
			get => GetProperty(ref _shootIntervalMinimum);
			set => SetProperty(ref _shootIntervalMinimum, value);
		}

		[Ordinal(18)] 
		[RED("shootIntervalMaximum")] 
		public CFloat ShootIntervalMaximum
		{
			get => GetProperty(ref _shootIntervalMaximum);
			set => SetProperty(ref _shootIntervalMaximum, value);
		}
	}
}
