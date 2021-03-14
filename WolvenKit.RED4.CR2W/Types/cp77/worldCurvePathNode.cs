using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCurvePathNode : worldSplineNode
	{
		private animCurvePathBakerUserInput _userInput;
		private Vector4 _defaultForwardVector;
		private CFloat _globalInBlendTime;
		private CFloat _globalOutBlendTime;
		private CName _defaultPoseAnimationName;
		private CFloat _defaultPoseSampleTime;
		private CFloat _initialDiffYaw;
		private CBool _turnCharacterToMatchVelocity;
		private rRef<animRig> _rig;
		private CArray<rRef<animAnimSet>> _animSets;
		private CFloat _timeDeltaMultiplier;

		[Ordinal(9)] 
		[RED("userInput")] 
		public animCurvePathBakerUserInput UserInput
		{
			get
			{
				if (_userInput == null)
				{
					_userInput = (animCurvePathBakerUserInput) CR2WTypeManager.Create("animCurvePathBakerUserInput", "userInput", cr2w, this);
				}
				return _userInput;
			}
			set
			{
				if (_userInput == value)
				{
					return;
				}
				_userInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("defaultForwardVector")] 
		public Vector4 DefaultForwardVector
		{
			get
			{
				if (_defaultForwardVector == null)
				{
					_defaultForwardVector = (Vector4) CR2WTypeManager.Create("Vector4", "defaultForwardVector", cr2w, this);
				}
				return _defaultForwardVector;
			}
			set
			{
				if (_defaultForwardVector == value)
				{
					return;
				}
				_defaultForwardVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("globalInBlendTime")] 
		public CFloat GlobalInBlendTime
		{
			get
			{
				if (_globalInBlendTime == null)
				{
					_globalInBlendTime = (CFloat) CR2WTypeManager.Create("Float", "globalInBlendTime", cr2w, this);
				}
				return _globalInBlendTime;
			}
			set
			{
				if (_globalInBlendTime == value)
				{
					return;
				}
				_globalInBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("globalOutBlendTime")] 
		public CFloat GlobalOutBlendTime
		{
			get
			{
				if (_globalOutBlendTime == null)
				{
					_globalOutBlendTime = (CFloat) CR2WTypeManager.Create("Float", "globalOutBlendTime", cr2w, this);
				}
				return _globalOutBlendTime;
			}
			set
			{
				if (_globalOutBlendTime == value)
				{
					return;
				}
				_globalOutBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("defaultPoseAnimationName")] 
		public CName DefaultPoseAnimationName
		{
			get
			{
				if (_defaultPoseAnimationName == null)
				{
					_defaultPoseAnimationName = (CName) CR2WTypeManager.Create("CName", "defaultPoseAnimationName", cr2w, this);
				}
				return _defaultPoseAnimationName;
			}
			set
			{
				if (_defaultPoseAnimationName == value)
				{
					return;
				}
				_defaultPoseAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("defaultPoseSampleTime")] 
		public CFloat DefaultPoseSampleTime
		{
			get
			{
				if (_defaultPoseSampleTime == null)
				{
					_defaultPoseSampleTime = (CFloat) CR2WTypeManager.Create("Float", "defaultPoseSampleTime", cr2w, this);
				}
				return _defaultPoseSampleTime;
			}
			set
			{
				if (_defaultPoseSampleTime == value)
				{
					return;
				}
				_defaultPoseSampleTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("initialDiffYaw")] 
		public CFloat InitialDiffYaw
		{
			get
			{
				if (_initialDiffYaw == null)
				{
					_initialDiffYaw = (CFloat) CR2WTypeManager.Create("Float", "initialDiffYaw", cr2w, this);
				}
				return _initialDiffYaw;
			}
			set
			{
				if (_initialDiffYaw == value)
				{
					return;
				}
				_initialDiffYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CBool TurnCharacterToMatchVelocity
		{
			get
			{
				if (_turnCharacterToMatchVelocity == null)
				{
					_turnCharacterToMatchVelocity = (CBool) CR2WTypeManager.Create("Bool", "turnCharacterToMatchVelocity", cr2w, this);
				}
				return _turnCharacterToMatchVelocity;
			}
			set
			{
				if (_turnCharacterToMatchVelocity == value)
				{
					return;
				}
				_turnCharacterToMatchVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("rig")] 
		public rRef<animRig> Rig
		{
			get
			{
				if (_rig == null)
				{
					_rig = (rRef<animRig>) CR2WTypeManager.Create("rRef:animRig", "rig", cr2w, this);
				}
				return _rig;
			}
			set
			{
				if (_rig == value)
				{
					return;
				}
				_rig = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("animSets")] 
		public CArray<rRef<animAnimSet>> AnimSets
		{
			get
			{
				if (_animSets == null)
				{
					_animSets = (CArray<rRef<animAnimSet>>) CR2WTypeManager.Create("array:rRef:animAnimSet", "animSets", cr2w, this);
				}
				return _animSets;
			}
			set
			{
				if (_animSets == value)
				{
					return;
				}
				_animSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("timeDeltaMultiplier")] 
		public CFloat TimeDeltaMultiplier
		{
			get
			{
				if (_timeDeltaMultiplier == null)
				{
					_timeDeltaMultiplier = (CFloat) CR2WTypeManager.Create("Float", "timeDeltaMultiplier", cr2w, this);
				}
				return _timeDeltaMultiplier;
			}
			set
			{
				if (_timeDeltaMultiplier == value)
				{
					return;
				}
				_timeDeltaMultiplier = value;
				PropertySet(this);
			}
		}

		public worldCurvePathNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
