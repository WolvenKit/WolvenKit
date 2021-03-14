using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Drag_ : animAnimNode_OnePoseInput
	{
		private animTransformIndex _sourceBone;
		private animTransformIndex _outTargetBone;
		private CFloat _simulationFps;
		private CFloat _sourceSpeedMultiplier;
		private CBool _hasOvershoot;
		private CFloat _overshootDuration;
		private CFloat _overshootDetectionMinSpeed;
		private CFloat _overshootDetectionMaxSpeed;
		private CBool _useSteps;
		private CFloat _stepsTargetSpeedMultiplier;
		private CFloat _timeBetweenSteps;
		private CFloat _timeInStep;

		[Ordinal(12)] 
		[RED("sourceBone")] 
		public animTransformIndex SourceBone
		{
			get
			{
				if (_sourceBone == null)
				{
					_sourceBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "sourceBone", cr2w, this);
				}
				return _sourceBone;
			}
			set
			{
				if (_sourceBone == value)
				{
					return;
				}
				_sourceBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("outTargetBone")] 
		public animTransformIndex OutTargetBone
		{
			get
			{
				if (_outTargetBone == null)
				{
					_outTargetBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "outTargetBone", cr2w, this);
				}
				return _outTargetBone;
			}
			set
			{
				if (_outTargetBone == value)
				{
					return;
				}
				_outTargetBone = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("simulationFps")] 
		public CFloat SimulationFps
		{
			get
			{
				if (_simulationFps == null)
				{
					_simulationFps = (CFloat) CR2WTypeManager.Create("Float", "simulationFps", cr2w, this);
				}
				return _simulationFps;
			}
			set
			{
				if (_simulationFps == value)
				{
					return;
				}
				_simulationFps = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("sourceSpeedMultiplier")] 
		public CFloat SourceSpeedMultiplier
		{
			get
			{
				if (_sourceSpeedMultiplier == null)
				{
					_sourceSpeedMultiplier = (CFloat) CR2WTypeManager.Create("Float", "sourceSpeedMultiplier", cr2w, this);
				}
				return _sourceSpeedMultiplier;
			}
			set
			{
				if (_sourceSpeedMultiplier == value)
				{
					return;
				}
				_sourceSpeedMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("hasOvershoot")] 
		public CBool HasOvershoot
		{
			get
			{
				if (_hasOvershoot == null)
				{
					_hasOvershoot = (CBool) CR2WTypeManager.Create("Bool", "hasOvershoot", cr2w, this);
				}
				return _hasOvershoot;
			}
			set
			{
				if (_hasOvershoot == value)
				{
					return;
				}
				_hasOvershoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("overshootDuration")] 
		public CFloat OvershootDuration
		{
			get
			{
				if (_overshootDuration == null)
				{
					_overshootDuration = (CFloat) CR2WTypeManager.Create("Float", "overshootDuration", cr2w, this);
				}
				return _overshootDuration;
			}
			set
			{
				if (_overshootDuration == value)
				{
					return;
				}
				_overshootDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("overshootDetectionMinSpeed")] 
		public CFloat OvershootDetectionMinSpeed
		{
			get
			{
				if (_overshootDetectionMinSpeed == null)
				{
					_overshootDetectionMinSpeed = (CFloat) CR2WTypeManager.Create("Float", "overshootDetectionMinSpeed", cr2w, this);
				}
				return _overshootDetectionMinSpeed;
			}
			set
			{
				if (_overshootDetectionMinSpeed == value)
				{
					return;
				}
				_overshootDetectionMinSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("overshootDetectionMaxSpeed")] 
		public CFloat OvershootDetectionMaxSpeed
		{
			get
			{
				if (_overshootDetectionMaxSpeed == null)
				{
					_overshootDetectionMaxSpeed = (CFloat) CR2WTypeManager.Create("Float", "overshootDetectionMaxSpeed", cr2w, this);
				}
				return _overshootDetectionMaxSpeed;
			}
			set
			{
				if (_overshootDetectionMaxSpeed == value)
				{
					return;
				}
				_overshootDetectionMaxSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("useSteps")] 
		public CBool UseSteps
		{
			get
			{
				if (_useSteps == null)
				{
					_useSteps = (CBool) CR2WTypeManager.Create("Bool", "useSteps", cr2w, this);
				}
				return _useSteps;
			}
			set
			{
				if (_useSteps == value)
				{
					return;
				}
				_useSteps = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("stepsTargetSpeedMultiplier")] 
		public CFloat StepsTargetSpeedMultiplier
		{
			get
			{
				if (_stepsTargetSpeedMultiplier == null)
				{
					_stepsTargetSpeedMultiplier = (CFloat) CR2WTypeManager.Create("Float", "stepsTargetSpeedMultiplier", cr2w, this);
				}
				return _stepsTargetSpeedMultiplier;
			}
			set
			{
				if (_stepsTargetSpeedMultiplier == value)
				{
					return;
				}
				_stepsTargetSpeedMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("timeBetweenSteps")] 
		public CFloat TimeBetweenSteps
		{
			get
			{
				if (_timeBetweenSteps == null)
				{
					_timeBetweenSteps = (CFloat) CR2WTypeManager.Create("Float", "timeBetweenSteps", cr2w, this);
				}
				return _timeBetweenSteps;
			}
			set
			{
				if (_timeBetweenSteps == value)
				{
					return;
				}
				_timeBetweenSteps = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("timeInStep")] 
		public CFloat TimeInStep
		{
			get
			{
				if (_timeInStep == null)
				{
					_timeInStep = (CFloat) CR2WTypeManager.Create("Float", "timeInStep", cr2w, this);
				}
				return _timeInStep;
			}
			set
			{
				if (_timeInStep == value)
				{
					return;
				}
				_timeInStep = value;
				PropertySet(this);
			}
		}

		public animAnimNode_Drag_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
