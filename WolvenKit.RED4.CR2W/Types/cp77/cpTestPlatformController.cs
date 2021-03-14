using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpTestPlatformController : gameObject
	{
		private NodeRef _platform;
		private NodeRef _pointA;
		private NodeRef _pointB;
		private CFloat _speed;

		[Ordinal(40)] 
		[RED("platform")] 
		public NodeRef Platform
		{
			get
			{
				if (_platform == null)
				{
					_platform = (NodeRef) CR2WTypeManager.Create("NodeRef", "platform", cr2w, this);
				}
				return _platform;
			}
			set
			{
				if (_platform == value)
				{
					return;
				}
				_platform = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("pointA")] 
		public NodeRef PointA
		{
			get
			{
				if (_pointA == null)
				{
					_pointA = (NodeRef) CR2WTypeManager.Create("NodeRef", "pointA", cr2w, this);
				}
				return _pointA;
			}
			set
			{
				if (_pointA == value)
				{
					return;
				}
				_pointA = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("pointB")] 
		public NodeRef PointB
		{
			get
			{
				if (_pointB == null)
				{
					_pointB = (NodeRef) CR2WTypeManager.Create("NodeRef", "pointB", cr2w, this);
				}
				return _pointB;
			}
			set
			{
				if (_pointB == value)
				{
					return;
				}
				_pointB = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
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

		public cpTestPlatformController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
