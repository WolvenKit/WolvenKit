using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsBumpEvent : redEvent
	{
		private CEnum<gameinteractionsBumpSide> _side;
		private CEnum<gameinteractionsBumpLocation> _sourceLocation;
		private Vector4 _direction;
		private Vector4 _sourcePosition;
		private CFloat _sourceSquaredDistance;
		private CFloat _sourceSpeed;
		private CBool _isMounted;
		private CFloat _sourceRadius;

		[Ordinal(0)] 
		[RED("side")] 
		public CEnum<gameinteractionsBumpSide> Side
		{
			get
			{
				if (_side == null)
				{
					_side = (CEnum<gameinteractionsBumpSide>) CR2WTypeManager.Create("gameinteractionsBumpSide", "side", cr2w, this);
				}
				return _side;
			}
			set
			{
				if (_side == value)
				{
					return;
				}
				_side = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sourceLocation")] 
		public CEnum<gameinteractionsBumpLocation> SourceLocation
		{
			get
			{
				if (_sourceLocation == null)
				{
					_sourceLocation = (CEnum<gameinteractionsBumpLocation>) CR2WTypeManager.Create("gameinteractionsBumpLocation", "sourceLocation", cr2w, this);
				}
				return _sourceLocation;
			}
			set
			{
				if (_sourceLocation == value)
				{
					return;
				}
				_sourceLocation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (Vector4) CR2WTypeManager.Create("Vector4", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sourcePosition")] 
		public Vector4 SourcePosition
		{
			get
			{
				if (_sourcePosition == null)
				{
					_sourcePosition = (Vector4) CR2WTypeManager.Create("Vector4", "sourcePosition", cr2w, this);
				}
				return _sourcePosition;
			}
			set
			{
				if (_sourcePosition == value)
				{
					return;
				}
				_sourcePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("sourceSquaredDistance")] 
		public CFloat SourceSquaredDistance
		{
			get
			{
				if (_sourceSquaredDistance == null)
				{
					_sourceSquaredDistance = (CFloat) CR2WTypeManager.Create("Float", "sourceSquaredDistance", cr2w, this);
				}
				return _sourceSquaredDistance;
			}
			set
			{
				if (_sourceSquaredDistance == value)
				{
					return;
				}
				_sourceSquaredDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("sourceSpeed")] 
		public CFloat SourceSpeed
		{
			get
			{
				if (_sourceSpeed == null)
				{
					_sourceSpeed = (CFloat) CR2WTypeManager.Create("Float", "sourceSpeed", cr2w, this);
				}
				return _sourceSpeed;
			}
			set
			{
				if (_sourceSpeed == value)
				{
					return;
				}
				_sourceSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isMounted")] 
		public CBool IsMounted
		{
			get
			{
				if (_isMounted == null)
				{
					_isMounted = (CBool) CR2WTypeManager.Create("Bool", "isMounted", cr2w, this);
				}
				return _isMounted;
			}
			set
			{
				if (_isMounted == value)
				{
					return;
				}
				_isMounted = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("sourceRadius")] 
		public CFloat SourceRadius
		{
			get
			{
				if (_sourceRadius == null)
				{
					_sourceRadius = (CFloat) CR2WTypeManager.Create("Float", "sourceRadius", cr2w, this);
				}
				return _sourceRadius;
			}
			set
			{
				if (_sourceRadius == value)
				{
					return;
				}
				_sourceRadius = value;
				PropertySet(this);
			}
		}

		public gameinteractionsBumpEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
