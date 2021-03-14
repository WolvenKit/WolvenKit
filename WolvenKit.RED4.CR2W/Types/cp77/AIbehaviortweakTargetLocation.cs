using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviortweakTargetLocation : CVariable
	{
		private wCHandle<gameObject> _object;
		private Vector3 _position;
		private Vector3 _speed;
		private AIObjectId _coverId;
		private CBool _hasPosition;
		private CBool _hasSpeed;

		[Ordinal(0)] 
		[RED("object")] 
		public wCHandle<gameObject> Object
		{
			get
			{
				if (_object == null)
				{
					_object = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "object", cr2w, this);
				}
				return _object;
			}
			set
			{
				if (_object == value)
				{
					return;
				}
				_object = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector3 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector3) CR2WTypeManager.Create("Vector3", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public Vector3 Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (Vector3) CR2WTypeManager.Create("Vector3", "speed", cr2w, this);
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

		[Ordinal(3)] 
		[RED("coverId")] 
		public AIObjectId CoverId
		{
			get
			{
				if (_coverId == null)
				{
					_coverId = (AIObjectId) CR2WTypeManager.Create("AIObjectId", "coverId", cr2w, this);
				}
				return _coverId;
			}
			set
			{
				if (_coverId == value)
				{
					return;
				}
				_coverId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hasPosition")] 
		public CBool HasPosition
		{
			get
			{
				if (_hasPosition == null)
				{
					_hasPosition = (CBool) CR2WTypeManager.Create("Bool", "hasPosition", cr2w, this);
				}
				return _hasPosition;
			}
			set
			{
				if (_hasPosition == value)
				{
					return;
				}
				_hasPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hasSpeed")] 
		public CBool HasSpeed
		{
			get
			{
				if (_hasSpeed == null)
				{
					_hasSpeed = (CBool) CR2WTypeManager.Create("Bool", "hasSpeed", cr2w, this);
				}
				return _hasSpeed;
			}
			set
			{
				if (_hasSpeed == value)
				{
					return;
				}
				_hasSpeed = value;
				PropertySet(this);
			}
		}

		public AIbehaviortweakTargetLocation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
