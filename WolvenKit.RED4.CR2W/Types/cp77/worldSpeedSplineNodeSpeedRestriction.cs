using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSpeedSplineNodeSpeedRestriction : CVariable
	{
		private CFloat _speed;
		private CFloat _from;
		private CFloat _adjustTime;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("from")] 
		public CFloat From
		{
			get
			{
				if (_from == null)
				{
					_from = (CFloat) CR2WTypeManager.Create("Float", "from", cr2w, this);
				}
				return _from;
			}
			set
			{
				if (_from == value)
				{
					return;
				}
				_from = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("adjustTime")] 
		public CFloat AdjustTime
		{
			get
			{
				if (_adjustTime == null)
				{
					_adjustTime = (CFloat) CR2WTypeManager.Create("Float", "adjustTime", cr2w, this);
				}
				return _adjustTime;
			}
			set
			{
				if (_adjustTime == value)
				{
					return;
				}
				_adjustTime = value;
				PropertySet(this);
			}
		}

		public worldSpeedSplineNodeSpeedRestriction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
