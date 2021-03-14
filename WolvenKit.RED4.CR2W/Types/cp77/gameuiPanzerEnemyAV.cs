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
			get
			{
				if (_speed == null)
				{
					_speed = (CFloat) CR2WTypeManager.Create("Float", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("shotsAmount")] 
		public CUInt32 ShotsAmount
		{
			get
			{
				if (_shotsAmount == null)
				{
					_shotsAmount = (CUInt32) CR2WTypeManager.Create("Uint32", "shotsAmount", cr2w, this);
				}
				return _shotsAmount;
			}
			set
			{
				if (_shotsAmount == value)
				{
					return;
				}
				_shotsAmount = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("longShotInterval")] 
		public CFloat LongShotInterval
		{
			get
			{
				if (_longShotInterval == null)
				{
					_longShotInterval = (CFloat) CR2WTypeManager.Create("Float", "longShotInterval", cr2w, this);
				}
				return _longShotInterval;
			}
			set
			{
				if (_longShotInterval == value)
				{
					return;
				}
				_longShotInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("shortShotInterval")] 
		public CFloat ShortShotInterval
		{
			get
			{
				if (_shortShotInterval == null)
				{
					_shortShotInterval = (CFloat) CR2WTypeManager.Create("Float", "shortShotInterval", cr2w, this);
				}
				return _shortShotInterval;
			}
			set
			{
				if (_shortShotInterval == value)
				{
					return;
				}
				_shortShotInterval = value;
				PropertySet(this);
			}
		}

		public gameuiPanzerEnemyAV(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
