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
		[RED("shootIntervalMinimum")] 
		public CFloat ShootIntervalMinimum
		{
			get
			{
				if (_shootIntervalMinimum == null)
				{
					_shootIntervalMinimum = (CFloat) CR2WTypeManager.Create("Float", "shootIntervalMinimum", cr2w, this);
				}
				return _shootIntervalMinimum;
			}
			set
			{
				if (_shootIntervalMinimum == value)
				{
					return;
				}
				_shootIntervalMinimum = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("shootIntervalMaximum")] 
		public CFloat ShootIntervalMaximum
		{
			get
			{
				if (_shootIntervalMaximum == null)
				{
					_shootIntervalMaximum = (CFloat) CR2WTypeManager.Create("Float", "shootIntervalMaximum", cr2w, this);
				}
				return _shootIntervalMaximum;
			}
			set
			{
				if (_shootIntervalMaximum == value)
				{
					return;
				}
				_shootIntervalMaximum = value;
				PropertySet(this);
			}
		}

		public gameuiPanzerEnemyDrone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
