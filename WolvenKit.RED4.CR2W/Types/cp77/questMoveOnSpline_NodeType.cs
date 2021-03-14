using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMoveOnSpline_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private NodeRef _splineRef;
		private CFloat _startFrom;
		private CEnum<vehiclePlayerToAIInterpolationType> _blendType;
		private CFloat _blendTime;
		private CBool _reverseGear;
		private CBool _arriveWithPivot;
		private CFloat _sceneBlendInDistance;
		private CFloat _sceneBlendOutDistance;
		private CHandle<questIVehicleMoveOnSpline_Overrides> _overrides;
		private rRef<vehicleAudioVehicleCurveSet> _audioCurves;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get
			{
				if (_vehicleRef == null)
				{
					_vehicleRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "vehicleRef", cr2w, this);
				}
				return _vehicleRef;
			}
			set
			{
				if (_vehicleRef == value)
				{
					return;
				}
				_vehicleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get
			{
				if (_splineRef == null)
				{
					_splineRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "splineRef", cr2w, this);
				}
				return _splineRef;
			}
			set
			{
				if (_splineRef == value)
				{
					return;
				}
				_splineRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startFrom")] 
		public CFloat StartFrom
		{
			get
			{
				if (_startFrom == null)
				{
					_startFrom = (CFloat) CR2WTypeManager.Create("Float", "startFrom", cr2w, this);
				}
				return _startFrom;
			}
			set
			{
				if (_startFrom == value)
				{
					return;
				}
				_startFrom = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("blendType")] 
		public CEnum<vehiclePlayerToAIInterpolationType> BlendType
		{
			get
			{
				if (_blendType == null)
				{
					_blendType = (CEnum<vehiclePlayerToAIInterpolationType>) CR2WTypeManager.Create("vehiclePlayerToAIInterpolationType", "blendType", cr2w, this);
				}
				return _blendType;
			}
			set
			{
				if (_blendType == value)
				{
					return;
				}
				_blendType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get
			{
				if (_blendTime == null)
				{
					_blendTime = (CFloat) CR2WTypeManager.Create("Float", "blendTime", cr2w, this);
				}
				return _blendTime;
			}
			set
			{
				if (_blendTime == value)
				{
					return;
				}
				_blendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("reverseGear")] 
		public CBool ReverseGear
		{
			get
			{
				if (_reverseGear == null)
				{
					_reverseGear = (CBool) CR2WTypeManager.Create("Bool", "reverseGear", cr2w, this);
				}
				return _reverseGear;
			}
			set
			{
				if (_reverseGear == value)
				{
					return;
				}
				_reverseGear = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("arriveWithPivot")] 
		public CBool ArriveWithPivot
		{
			get
			{
				if (_arriveWithPivot == null)
				{
					_arriveWithPivot = (CBool) CR2WTypeManager.Create("Bool", "arriveWithPivot", cr2w, this);
				}
				return _arriveWithPivot;
			}
			set
			{
				if (_arriveWithPivot == value)
				{
					return;
				}
				_arriveWithPivot = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("sceneBlendInDistance")] 
		public CFloat SceneBlendInDistance
		{
			get
			{
				if (_sceneBlendInDistance == null)
				{
					_sceneBlendInDistance = (CFloat) CR2WTypeManager.Create("Float", "sceneBlendInDistance", cr2w, this);
				}
				return _sceneBlendInDistance;
			}
			set
			{
				if (_sceneBlendInDistance == value)
				{
					return;
				}
				_sceneBlendInDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("sceneBlendOutDistance")] 
		public CFloat SceneBlendOutDistance
		{
			get
			{
				if (_sceneBlendOutDistance == null)
				{
					_sceneBlendOutDistance = (CFloat) CR2WTypeManager.Create("Float", "sceneBlendOutDistance", cr2w, this);
				}
				return _sceneBlendOutDistance;
			}
			set
			{
				if (_sceneBlendOutDistance == value)
				{
					return;
				}
				_sceneBlendOutDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("overrides")] 
		public CHandle<questIVehicleMoveOnSpline_Overrides> Overrides
		{
			get
			{
				if (_overrides == null)
				{
					_overrides = (CHandle<questIVehicleMoveOnSpline_Overrides>) CR2WTypeManager.Create("handle:questIVehicleMoveOnSpline_Overrides", "overrides", cr2w, this);
				}
				return _overrides;
			}
			set
			{
				if (_overrides == value)
				{
					return;
				}
				_overrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("audioCurves")] 
		public rRef<vehicleAudioVehicleCurveSet> AudioCurves
		{
			get
			{
				if (_audioCurves == null)
				{
					_audioCurves = (rRef<vehicleAudioVehicleCurveSet>) CR2WTypeManager.Create("rRef:vehicleAudioVehicleCurveSet", "audioCurves", cr2w, this);
				}
				return _audioCurves;
			}
			set
			{
				if (_audioCurves == value)
				{
					return;
				}
				_audioCurves = value;
				PropertySet(this);
			}
		}

		public questMoveOnSpline_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
