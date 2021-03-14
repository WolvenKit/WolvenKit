using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpConveyorLine : CVariable
	{
		private NodeRef _spline;
		private CName _template;
		private CBool _reverseDirection;
		private CArray<Vector2> _physicsValidRanges;

		[Ordinal(0)] 
		[RED("spline")] 
		public NodeRef Spline
		{
			get
			{
				if (_spline == null)
				{
					_spline = (NodeRef) CR2WTypeManager.Create("NodeRef", "spline", cr2w, this);
				}
				return _spline;
			}
			set
			{
				if (_spline == value)
				{
					return;
				}
				_spline = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("template")] 
		public CName Template
		{
			get
			{
				if (_template == null)
				{
					_template = (CName) CR2WTypeManager.Create("CName", "template", cr2w, this);
				}
				return _template;
			}
			set
			{
				if (_template == value)
				{
					return;
				}
				_template = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("physicsValidRanges")] 
		public CArray<Vector2> PhysicsValidRanges
		{
			get
			{
				if (_physicsValidRanges == null)
				{
					_physicsValidRanges = (CArray<Vector2>) CR2WTypeManager.Create("array:Vector2", "physicsValidRanges", cr2w, this);
				}
				return _physicsValidRanges;
			}
			set
			{
				if (_physicsValidRanges == value)
				{
					return;
				}
				_physicsValidRanges = value;
				PropertySet(this);
			}
		}

		public cpConveyorLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
