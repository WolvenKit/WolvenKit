using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AddIkRequest : animAnimNode_OnePoseInput
	{
		private CName _ikChain;
		private animTransformIndex _targetBone;
		private Vector3 _positionOffset;
		private Quaternion _rotationOffset;
		private animPoleVectorDetails _poleVector;
		private CFloat _weightPosition;
		private CFloat _weightRotation;
		private CFloat _blendTimeIn;
		private CFloat _blendTimeOut;
		private CInt32 _priority;

		[Ordinal(12)] 
		[RED("ikChain")] 
		public CName IkChain
		{
			get
			{
				if (_ikChain == null)
				{
					_ikChain = (CName) CR2WTypeManager.Create("CName", "ikChain", cr2w, this);
				}
				return _ikChain;
			}
			set
			{
				if (_ikChain == value)
				{
					return;
				}
				_ikChain = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("targetBone")] 
		public animTransformIndex TargetBone
		{
			get
			{
				if (_targetBone == null)
				{
					_targetBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "targetBone", cr2w, this);
				}
				return _targetBone;
			}
			set
			{
				if (_targetBone == value)
				{
					return;
				}
				_targetBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("positionOffset")] 
		public Vector3 PositionOffset
		{
			get
			{
				if (_positionOffset == null)
				{
					_positionOffset = (Vector3) CR2WTypeManager.Create("Vector3", "positionOffset", cr2w, this);
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("poleVector")] 
		public animPoleVectorDetails PoleVector
		{
			get
			{
				if (_poleVector == null)
				{
					_poleVector = (animPoleVectorDetails) CR2WTypeManager.Create("animPoleVectorDetails", "poleVector", cr2w, this);
				}
				return _poleVector;
			}
			set
			{
				if (_poleVector == value)
				{
					return;
				}
				_poleVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("weightPosition")] 
		public CFloat WeightPosition
		{
			get
			{
				if (_weightPosition == null)
				{
					_weightPosition = (CFloat) CR2WTypeManager.Create("Float", "weightPosition", cr2w, this);
				}
				return _weightPosition;
			}
			set
			{
				if (_weightPosition == value)
				{
					return;
				}
				_weightPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("weightRotation")] 
		public CFloat WeightRotation
		{
			get
			{
				if (_weightRotation == null)
				{
					_weightRotation = (CFloat) CR2WTypeManager.Create("Float", "weightRotation", cr2w, this);
				}
				return _weightRotation;
			}
			set
			{
				if (_weightRotation == value)
				{
					return;
				}
				_weightRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("blendTimeIn")] 
		public CFloat BlendTimeIn
		{
			get
			{
				if (_blendTimeIn == null)
				{
					_blendTimeIn = (CFloat) CR2WTypeManager.Create("Float", "blendTimeIn", cr2w, this);
				}
				return _blendTimeIn;
			}
			set
			{
				if (_blendTimeIn == value)
				{
					return;
				}
				_blendTimeIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("blendTimeOut")] 
		public CFloat BlendTimeOut
		{
			get
			{
				if (_blendTimeOut == null)
				{
					_blendTimeOut = (CFloat) CR2WTypeManager.Create("Float", "blendTimeOut", cr2w, this);
				}
				return _blendTimeOut;
			}
			set
			{
				if (_blendTimeOut == value)
				{
					return;
				}
				_blendTimeOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CInt32) CR2WTypeManager.Create("Int32", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		public animAnimNode_AddIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
