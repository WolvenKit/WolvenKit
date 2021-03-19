using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerEnemyAV : gameuiPanzerEnemy
	{
		private CFloat _speed;
		private CUInt32 _shotsAmount;
		private CFloat _longShotInterval;
		private CFloat _shortShotInterval;

		[Ordinal(16)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(17)] 
		[RED("shotsAmount")] 
		public CUInt32 ShotsAmount
		{
			get => GetProperty(ref _shotsAmount);
			set => SetProperty(ref _shotsAmount, value);
		}

		[Ordinal(18)] 
		[RED("longShotInterval")] 
		public CFloat LongShotInterval
		{
			get => GetProperty(ref _longShotInterval);
			set => SetProperty(ref _longShotInterval, value);
		}

		[Ordinal(19)] 
		[RED("shortShotInterval")] 
		public CFloat ShortShotInterval
		{
			get => GetProperty(ref _shortShotInterval);
			set => SetProperty(ref _shortShotInterval, value);
		}

		public gameuiPanzerEnemyAV(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
