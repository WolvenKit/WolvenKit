using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionDescription : ISerializable
	{
		private CUInt32 _targetStateIndex;
		private CHandle<animIAnimStateTransitionCondition> _condition;
		private CBool _isEnabled;
		private CHandle<animIAnimStateTransitionInterpolator> _interpolator;
		private CFloat _duration;
		private CInt32 _priority;
		private CHandle<animISyncMethod> _syncMethod;
		private CBool _isForcedToTrue;
		private CBool _supportBlendFromPose;
		private CBool _canRequestInertialization;
		private CName _animFeatureName;
		private rRef<animActionAnimDatabase> _actionAnimDatabaseRef;
		private CBool _isOutTransitionFromAction;

		[Ordinal(0)] 
		[RED("targetStateIndex")] 
		public CUInt32 TargetStateIndex
		{
			get
			{
				if (_targetStateIndex == null)
				{
					_targetStateIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "targetStateIndex", cr2w, this);
				}
				return _targetStateIndex;
			}
			set
			{
				if (_targetStateIndex == value)
				{
					return;
				}
				_targetStateIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<animIAnimStateTransitionCondition> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<animIAnimStateTransitionCondition>) CR2WTypeManager.Create("handle:animIAnimStateTransitionCondition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("interpolator")] 
		public CHandle<animIAnimStateTransitionInterpolator> Interpolator
		{
			get
			{
				if (_interpolator == null)
				{
					_interpolator = (CHandle<animIAnimStateTransitionInterpolator>) CR2WTypeManager.Create("handle:animIAnimStateTransitionInterpolator", "interpolator", cr2w, this);
				}
				return _interpolator;
			}
			set
			{
				if (_interpolator == value)
				{
					return;
				}
				_interpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get
			{
				if (_syncMethod == null)
				{
					_syncMethod = (CHandle<animISyncMethod>) CR2WTypeManager.Create("handle:animISyncMethod", "syncMethod", cr2w, this);
				}
				return _syncMethod;
			}
			set
			{
				if (_syncMethod == value)
				{
					return;
				}
				_syncMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isForcedToTrue")] 
		public CBool IsForcedToTrue
		{
			get
			{
				if (_isForcedToTrue == null)
				{
					_isForcedToTrue = (CBool) CR2WTypeManager.Create("Bool", "isForcedToTrue", cr2w, this);
				}
				return _isForcedToTrue;
			}
			set
			{
				if (_isForcedToTrue == value)
				{
					return;
				}
				_isForcedToTrue = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("supportBlendFromPose")] 
		public CBool SupportBlendFromPose
		{
			get
			{
				if (_supportBlendFromPose == null)
				{
					_supportBlendFromPose = (CBool) CR2WTypeManager.Create("Bool", "supportBlendFromPose", cr2w, this);
				}
				return _supportBlendFromPose;
			}
			set
			{
				if (_supportBlendFromPose == value)
				{
					return;
				}
				_supportBlendFromPose = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("canRequestInertialization")] 
		public CBool CanRequestInertialization
		{
			get
			{
				if (_canRequestInertialization == null)
				{
					_canRequestInertialization = (CBool) CR2WTypeManager.Create("Bool", "canRequestInertialization", cr2w, this);
				}
				return _canRequestInertialization;
			}
			set
			{
				if (_canRequestInertialization == value)
				{
					return;
				}
				_canRequestInertialization = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get
			{
				if (_animFeatureName == null)
				{
					_animFeatureName = (CName) CR2WTypeManager.Create("CName", "animFeatureName", cr2w, this);
				}
				return _animFeatureName;
			}
			set
			{
				if (_animFeatureName == value)
				{
					return;
				}
				_animFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("actionAnimDatabaseRef")] 
		public rRef<animActionAnimDatabase> ActionAnimDatabaseRef
		{
			get
			{
				if (_actionAnimDatabaseRef == null)
				{
					_actionAnimDatabaseRef = (rRef<animActionAnimDatabase>) CR2WTypeManager.Create("rRef:animActionAnimDatabase", "actionAnimDatabaseRef", cr2w, this);
				}
				return _actionAnimDatabaseRef;
			}
			set
			{
				if (_actionAnimDatabaseRef == value)
				{
					return;
				}
				_actionAnimDatabaseRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isOutTransitionFromAction")] 
		public CBool IsOutTransitionFromAction
		{
			get
			{
				if (_isOutTransitionFromAction == null)
				{
					_isOutTransitionFromAction = (CBool) CR2WTypeManager.Create("Bool", "isOutTransitionFromAction", cr2w, this);
				}
				return _isOutTransitionFromAction;
			}
			set
			{
				if (_isOutTransitionFromAction == value)
				{
					return;
				}
				_isOutTransitionFromAction = value;
				PropertySet(this);
			}
		}

		public animAnimStateTransitionDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
