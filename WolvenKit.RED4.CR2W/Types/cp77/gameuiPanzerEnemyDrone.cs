using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerEnemyDrone : gameuiPanzerEnemy
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

		public gameuiPanzerEnemyDrone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
