using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAdaptiveLookAtParams : scnChoiceNodeNsLookAtParams
	{
		private CName _nearbySlotName;
		private CName _distantSlotName;
		private CFloat _blendLimit;
		private CFloat _referencePointFullEffectAngle;
		private CFloat _referencePointNoEffectAngle;
		private CFloat _referencePointFullEffectDistance;
		private CFloat _referencePointNoEffectDistance;
		private CArray<scnChoiceNodeNsAdaptiveLookAtReferencePoint> _referencePoints;
		private Vector3 _auxiliaryRelativePoint;

		[Ordinal(0)] 
		[RED("nearbySlotName")] 
		public CName NearbySlotName
		{
			get
			{
				if (_nearbySlotName == null)
				{
					_nearbySlotName = (CName) CR2WTypeManager.Create("CName", "nearbySlotName", cr2w, this);
				}
				return _nearbySlotName;
			}
			set
			{
				if (_nearbySlotName == value)
				{
					return;
				}
				_nearbySlotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("distantSlotName")] 
		public CName DistantSlotName
		{
			get
			{
				if (_distantSlotName == null)
				{
					_distantSlotName = (CName) CR2WTypeManager.Create("CName", "distantSlotName", cr2w, this);
				}
				return _distantSlotName;
			}
			set
			{
				if (_distantSlotName == value)
				{
					return;
				}
				_distantSlotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blendLimit")] 
		public CFloat BlendLimit
		{
			get
			{
				if (_blendLimit == null)
				{
					_blendLimit = (CFloat) CR2WTypeManager.Create("Float", "blendLimit", cr2w, this);
				}
				return _blendLimit;
			}
			set
			{
				if (_blendLimit == value)
				{
					return;
				}
				_blendLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("referencePointFullEffectAngle")] 
		public CFloat ReferencePointFullEffectAngle
		{
			get
			{
				if (_referencePointFullEffectAngle == null)
				{
					_referencePointFullEffectAngle = (CFloat) CR2WTypeManager.Create("Float", "referencePointFullEffectAngle", cr2w, this);
				}
				return _referencePointFullEffectAngle;
			}
			set
			{
				if (_referencePointFullEffectAngle == value)
				{
					return;
				}
				_referencePointFullEffectAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("referencePointNoEffectAngle")] 
		public CFloat ReferencePointNoEffectAngle
		{
			get
			{
				if (_referencePointNoEffectAngle == null)
				{
					_referencePointNoEffectAngle = (CFloat) CR2WTypeManager.Create("Float", "referencePointNoEffectAngle", cr2w, this);
				}
				return _referencePointNoEffectAngle;
			}
			set
			{
				if (_referencePointNoEffectAngle == value)
				{
					return;
				}
				_referencePointNoEffectAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("referencePointFullEffectDistance")] 
		public CFloat ReferencePointFullEffectDistance
		{
			get
			{
				if (_referencePointFullEffectDistance == null)
				{
					_referencePointFullEffectDistance = (CFloat) CR2WTypeManager.Create("Float", "referencePointFullEffectDistance", cr2w, this);
				}
				return _referencePointFullEffectDistance;
			}
			set
			{
				if (_referencePointFullEffectDistance == value)
				{
					return;
				}
				_referencePointFullEffectDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("referencePointNoEffectDistance")] 
		public CFloat ReferencePointNoEffectDistance
		{
			get
			{
				if (_referencePointNoEffectDistance == null)
				{
					_referencePointNoEffectDistance = (CFloat) CR2WTypeManager.Create("Float", "referencePointNoEffectDistance", cr2w, this);
				}
				return _referencePointNoEffectDistance;
			}
			set
			{
				if (_referencePointNoEffectDistance == value)
				{
					return;
				}
				_referencePointNoEffectDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("referencePoints")] 
		public CArray<scnChoiceNodeNsAdaptiveLookAtReferencePoint> ReferencePoints
		{
			get
			{
				if (_referencePoints == null)
				{
					_referencePoints = (CArray<scnChoiceNodeNsAdaptiveLookAtReferencePoint>) CR2WTypeManager.Create("array:scnChoiceNodeNsAdaptiveLookAtReferencePoint", "referencePoints", cr2w, this);
				}
				return _referencePoints;
			}
			set
			{
				if (_referencePoints == value)
				{
					return;
				}
				_referencePoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("auxiliaryRelativePoint")] 
		public Vector3 AuxiliaryRelativePoint
		{
			get
			{
				if (_auxiliaryRelativePoint == null)
				{
					_auxiliaryRelativePoint = (Vector3) CR2WTypeManager.Create("Vector3", "auxiliaryRelativePoint", cr2w, this);
				}
				return _auxiliaryRelativePoint;
			}
			set
			{
				if (_auxiliaryRelativePoint == value)
				{
					return;
				}
				_auxiliaryRelativePoint = value;
				PropertySet(this);
			}
		}

		public scnChoiceNodeNsAdaptiveLookAtParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
