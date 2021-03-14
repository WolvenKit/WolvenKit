using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIRotateToCommand : AIMoveCommand
	{
		private AIPositionSpec _target;
		private CFloat _angleTolerance;
		private CFloat _angleOffset;
		private CFloat _speed;

		[Ordinal(7)] 
		[RED("target")] 
		public AIPositionSpec Target
		{
			get
			{
				if (_target == null)
				{
					_target = (AIPositionSpec) CR2WTypeManager.Create("AIPositionSpec", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("angleTolerance")] 
		public CFloat AngleTolerance
		{
			get
			{
				if (_angleTolerance == null)
				{
					_angleTolerance = (CFloat) CR2WTypeManager.Create("Float", "angleTolerance", cr2w, this);
				}
				return _angleTolerance;
			}
			set
			{
				if (_angleTolerance == value)
				{
					return;
				}
				_angleTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get
			{
				if (_angleOffset == null)
				{
					_angleOffset = (CFloat) CR2WTypeManager.Create("Float", "angleOffset", cr2w, this);
				}
				return _angleOffset;
			}
			set
			{
				if (_angleOffset == value)
				{
					return;
				}
				_angleOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		public AIRotateToCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
