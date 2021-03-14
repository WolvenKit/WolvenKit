using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetTier3Params_NodeType : questISceneManagerNodeType
	{
		private CFloat _yawLeftLimit;
		private CFloat _yawRightLimit;
		private CFloat _pitchUpLimit;
		private CFloat _pitchDownLimit;
		private CFloat _yawSpeedMultiplier;
		private CFloat _pitchSpeedMultiplier;
		private gameEntityReference _objectRef;
		private CName _slotName;
		private Vector3 _offsetPos;
		private CFloat _rotationTime;
		private CBool _rotateHeadOnly;
		private CBool _usePlayerWorkspot;
		private CBool _useEnterAnim;
		private CBool _useExitAnim;

		[Ordinal(0)] 
		[RED("yawLeftLimit")] 
		public CFloat YawLeftLimit
		{
			get
			{
				if (_yawLeftLimit == null)
				{
					_yawLeftLimit = (CFloat) CR2WTypeManager.Create("Float", "yawLeftLimit", cr2w, this);
				}
				return _yawLeftLimit;
			}
			set
			{
				if (_yawLeftLimit == value)
				{
					return;
				}
				_yawLeftLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("yawRightLimit")] 
		public CFloat YawRightLimit
		{
			get
			{
				if (_yawRightLimit == null)
				{
					_yawRightLimit = (CFloat) CR2WTypeManager.Create("Float", "yawRightLimit", cr2w, this);
				}
				return _yawRightLimit;
			}
			set
			{
				if (_yawRightLimit == value)
				{
					return;
				}
				_yawRightLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pitchUpLimit")] 
		public CFloat PitchUpLimit
		{
			get
			{
				if (_pitchUpLimit == null)
				{
					_pitchUpLimit = (CFloat) CR2WTypeManager.Create("Float", "pitchUpLimit", cr2w, this);
				}
				return _pitchUpLimit;
			}
			set
			{
				if (_pitchUpLimit == value)
				{
					return;
				}
				_pitchUpLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pitchDownLimit")] 
		public CFloat PitchDownLimit
		{
			get
			{
				if (_pitchDownLimit == null)
				{
					_pitchDownLimit = (CFloat) CR2WTypeManager.Create("Float", "pitchDownLimit", cr2w, this);
				}
				return _pitchDownLimit;
			}
			set
			{
				if (_pitchDownLimit == value)
				{
					return;
				}
				_pitchDownLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("yawSpeedMultiplier")] 
		public CFloat YawSpeedMultiplier
		{
			get
			{
				if (_yawSpeedMultiplier == null)
				{
					_yawSpeedMultiplier = (CFloat) CR2WTypeManager.Create("Float", "yawSpeedMultiplier", cr2w, this);
				}
				return _yawSpeedMultiplier;
			}
			set
			{
				if (_yawSpeedMultiplier == value)
				{
					return;
				}
				_yawSpeedMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("pitchSpeedMultiplier")] 
		public CFloat PitchSpeedMultiplier
		{
			get
			{
				if (_pitchSpeedMultiplier == null)
				{
					_pitchSpeedMultiplier = (CFloat) CR2WTypeManager.Create("Float", "pitchSpeedMultiplier", cr2w, this);
				}
				return _pitchSpeedMultiplier;
			}
			set
			{
				if (_pitchSpeedMultiplier == value)
				{
					return;
				}
				_pitchSpeedMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("offsetPos")] 
		public Vector3 OffsetPos
		{
			get
			{
				if (_offsetPos == null)
				{
					_offsetPos = (Vector3) CR2WTypeManager.Create("Vector3", "offsetPos", cr2w, this);
				}
				return _offsetPos;
			}
			set
			{
				if (_offsetPos == value)
				{
					return;
				}
				_offsetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("rotationTime")] 
		public CFloat RotationTime
		{
			get
			{
				if (_rotationTime == null)
				{
					_rotationTime = (CFloat) CR2WTypeManager.Create("Float", "rotationTime", cr2w, this);
				}
				return _rotationTime;
			}
			set
			{
				if (_rotationTime == value)
				{
					return;
				}
				_rotationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("rotateHeadOnly")] 
		public CBool RotateHeadOnly
		{
			get
			{
				if (_rotateHeadOnly == null)
				{
					_rotateHeadOnly = (CBool) CR2WTypeManager.Create("Bool", "rotateHeadOnly", cr2w, this);
				}
				return _rotateHeadOnly;
			}
			set
			{
				if (_rotateHeadOnly == value)
				{
					return;
				}
				_rotateHeadOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("usePlayerWorkspot")] 
		public CBool UsePlayerWorkspot
		{
			get
			{
				if (_usePlayerWorkspot == null)
				{
					_usePlayerWorkspot = (CBool) CR2WTypeManager.Create("Bool", "usePlayerWorkspot", cr2w, this);
				}
				return _usePlayerWorkspot;
			}
			set
			{
				if (_usePlayerWorkspot == value)
				{
					return;
				}
				_usePlayerWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("useEnterAnim")] 
		public CBool UseEnterAnim
		{
			get
			{
				if (_useEnterAnim == null)
				{
					_useEnterAnim = (CBool) CR2WTypeManager.Create("Bool", "useEnterAnim", cr2w, this);
				}
				return _useEnterAnim;
			}
			set
			{
				if (_useEnterAnim == value)
				{
					return;
				}
				_useEnterAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("useExitAnim")] 
		public CBool UseExitAnim
		{
			get
			{
				if (_useExitAnim == null)
				{
					_useExitAnim = (CBool) CR2WTypeManager.Create("Bool", "useExitAnim", cr2w, this);
				}
				return _useExitAnim;
			}
			set
			{
				if (_useExitAnim == value)
				{
					return;
				}
				_useExitAnim = value;
				PropertySet(this);
			}
		}

		public questSetTier3Params_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
