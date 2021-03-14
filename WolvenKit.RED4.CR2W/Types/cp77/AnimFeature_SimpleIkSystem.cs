using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SimpleIkSystem : animAnimFeature
	{
		private CBool _isEnable;
		private CFloat _weight;
		private CBool _setPosition;
		private Vector4 _position;
		private Vector4 _positionOffset;
		private CBool _setRotation;
		private Quaternion _rotation;
		private Quaternion _rotationOffset;

		[Ordinal(0)] 
		[RED("isEnable")] 
		public CBool IsEnable
		{
			get
			{
				if (_isEnable == null)
				{
					_isEnable = (CBool) CR2WTypeManager.Create("Bool", "isEnable", cr2w, this);
				}
				return _isEnable;
			}
			set
			{
				if (_isEnable == value)
				{
					return;
				}
				_isEnable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("setPosition")] 
		public CBool SetPosition
		{
			get
			{
				if (_setPosition == null)
				{
					_setPosition = (CBool) CR2WTypeManager.Create("Bool", "setPosition", cr2w, this);
				}
				return _setPosition;
			}
			set
			{
				if (_setPosition == value)
				{
					return;
				}
				_setPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
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

		[Ordinal(4)] 
		[RED("positionOffset")] 
		public Vector4 PositionOffset
		{
			get
			{
				if (_positionOffset == null)
				{
					_positionOffset = (Vector4) CR2WTypeManager.Create("Vector4", "positionOffset", cr2w, this);
				}
				return _positionOffset;
			}
			set
			{
				if (_positionOffset == value)
				{
					return;
				}
				_positionOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("setRotation")] 
		public CBool SetRotation
		{
			get
			{
				if (_setRotation == null)
				{
					_setRotation = (CBool) CR2WTypeManager.Create("Bool", "setRotation", cr2w, this);
				}
				return _setRotation;
			}
			set
			{
				if (_setRotation == value)
				{
					return;
				}
				_setRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("rotationOffset")] 
		public Quaternion RotationOffset
		{
			get
			{
				if (_rotationOffset == null)
				{
					_rotationOffset = (Quaternion) CR2WTypeManager.Create("Quaternion", "rotationOffset", cr2w, this);
				}
				return _rotationOffset;
			}
			set
			{
				if (_rotationOffset == value)
				{
					return;
				}
				_rotationOffset = value;
				PropertySet(this);
			}
		}

		public AnimFeature_SimpleIkSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
