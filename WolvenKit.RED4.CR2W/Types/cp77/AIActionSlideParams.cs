using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionSlideParams : CVariable
	{
		private CFloat _distance;
		private CFloat _directionAngle;
		private CFloat _duration;
		private CFloat _offset;
		private CBool _slideToTarget;
		private CBool _debugDrawSlideLines;

		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("directionAngle")] 
		public CFloat DirectionAngle
		{
			get
			{
				if (_directionAngle == null)
				{
					_directionAngle = (CFloat) CR2WTypeManager.Create("Float", "directionAngle", cr2w, this);
				}
				return _directionAngle;
			}
			set
			{
				if (_directionAngle == value)
				{
					return;
				}
				_directionAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (CFloat) CR2WTypeManager.Create("Float", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("slideToTarget")] 
		public CBool SlideToTarget
		{
			get
			{
				if (_slideToTarget == null)
				{
					_slideToTarget = (CBool) CR2WTypeManager.Create("Bool", "slideToTarget", cr2w, this);
				}
				return _slideToTarget;
			}
			set
			{
				if (_slideToTarget == value)
				{
					return;
				}
				_slideToTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("debugDrawSlideLines")] 
		public CBool DebugDrawSlideLines
		{
			get
			{
				if (_debugDrawSlideLines == null)
				{
					_debugDrawSlideLines = (CBool) CR2WTypeManager.Create("Bool", "debugDrawSlideLines", cr2w, this);
				}
				return _debugDrawSlideLines;
			}
			set
			{
				if (_debugDrawSlideLines == value)
				{
					return;
				}
				_debugDrawSlideLines = value;
				PropertySet(this);
			}
		}

		public AIActionSlideParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
