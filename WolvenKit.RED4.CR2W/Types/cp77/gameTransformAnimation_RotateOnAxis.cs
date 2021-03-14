using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_RotateOnAxis : gameTransformAnimationTrackItemImpl
	{
		private CEnum<gameTransformAnimation_RotateOnAxisAxis> _axis;
		private CFloat _numberOfFullRotations;
		private CFloat _startAngle;
		private CBool _reverseDirection;
		private CHandle<gameTransformAnimation_Movement> _movement;

		[Ordinal(0)] 
		[RED("axis")] 
		public CEnum<gameTransformAnimation_RotateOnAxisAxis> Axis
		{
			get
			{
				if (_axis == null)
				{
					_axis = (CEnum<gameTransformAnimation_RotateOnAxisAxis>) CR2WTypeManager.Create("gameTransformAnimation_RotateOnAxisAxis", "axis", cr2w, this);
				}
				return _axis;
			}
			set
			{
				if (_axis == value)
				{
					return;
				}
				_axis = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("numberOfFullRotations")] 
		public CFloat NumberOfFullRotations
		{
			get
			{
				if (_numberOfFullRotations == null)
				{
					_numberOfFullRotations = (CFloat) CR2WTypeManager.Create("Float", "numberOfFullRotations", cr2w, this);
				}
				return _numberOfFullRotations;
			}
			set
			{
				if (_numberOfFullRotations == value)
				{
					return;
				}
				_numberOfFullRotations = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startAngle")] 
		public CFloat StartAngle
		{
			get
			{
				if (_startAngle == null)
				{
					_startAngle = (CFloat) CR2WTypeManager.Create("Float", "startAngle", cr2w, this);
				}
				return _startAngle;
			}
			set
			{
				if (_startAngle == value)
				{
					return;
				}
				_startAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("reverseDirection")] 
		public CBool ReverseDirection
		{
			get
			{
				if (_reverseDirection == null)
				{
					_reverseDirection = (CBool) CR2WTypeManager.Create("Bool", "reverseDirection", cr2w, this);
				}
				return _reverseDirection;
			}
			set
			{
				if (_reverseDirection == value)
				{
					return;
				}
				_reverseDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("movement")] 
		public CHandle<gameTransformAnimation_Movement> Movement
		{
			get
			{
				if (_movement == null)
				{
					_movement = (CHandle<gameTransformAnimation_Movement>) CR2WTypeManager.Create("handle:gameTransformAnimation_Movement", "movement", cr2w, this);
				}
				return _movement;
			}
			set
			{
				if (_movement == value)
				{
					return;
				}
				_movement = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimation_RotateOnAxis(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
