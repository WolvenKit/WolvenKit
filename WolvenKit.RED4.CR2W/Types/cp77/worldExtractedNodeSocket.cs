using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldExtractedNodeSocket : CVariable
	{
		private CName _name;
		private CName _displayName;
		private Vector3 _position;
		private Quaternion _rotation;
		private Vector3 _direction;
		private CEnum<worldNodeSocketType> _type;
		private CBool _isSnapped;
		private CColor _color;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("displayName")] 
		public CName DisplayName
		{
			get
			{
				if (_displayName == null)
				{
					_displayName = (CName) CR2WTypeManager.Create("CName", "displayName", cr2w, this);
				}
				return _displayName;
			}
			set
			{
				if (_displayName == value)
				{
					return;
				}
				_displayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("direction")] 
		public Vector3 Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (Vector3) CR2WTypeManager.Create("Vector3", "direction", cr2w, this);
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

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<worldNodeSocketType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<worldNodeSocketType>) CR2WTypeManager.Create("worldNodeSocketType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isSnapped")] 
		public CBool IsSnapped
		{
			get
			{
				if (_isSnapped == null)
				{
					_isSnapped = (CBool) CR2WTypeManager.Create("Bool", "isSnapped", cr2w, this);
				}
				return _isSnapped;
			}
			set
			{
				if (_isSnapped == value)
				{
					return;
				}
				_isSnapped = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		public worldExtractedNodeSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
