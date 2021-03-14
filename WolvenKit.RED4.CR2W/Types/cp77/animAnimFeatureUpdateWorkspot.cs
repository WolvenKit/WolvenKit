using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeatureUpdateWorkspot : animAnimFeature
	{
		private CName _animName;
		private CInt32 _recordID;
		private CInt32 _updateCounter;
		private CInt32 _boolsAsFlags;
		private CFloat _animBlendTime;
		private CFloat _forcedBlendIn;
		private CFloat _forceAnimTime;
		private CFloat _timeScale;
		private CDouble _animationStartTime;
		private CBool _isPaused;
		private CBool _isLooped;
		private CBool _isExitAnim;
		private CBool _enableMotion;
		private CBool _isActive;
		private CBool _isAnimValid;
		private CInt32 _slotNameHash;
		private CFloat _facialKeyWeight;
		private CName _facialIdleAnimation;
		private CName _facialIdleKeyAnimation;
		private CFloat _globalBlendDuration;
		private CBool _globalBlendIn;

		[Ordinal(0)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("recordID")] 
		public CInt32 RecordID
		{
			get
			{
				if (_recordID == null)
				{
					_recordID = (CInt32) CR2WTypeManager.Create("Int32", "recordID", cr2w, this);
				}
				return _recordID;
			}
			set
			{
				if (_recordID == value)
				{
					return;
				}
				_recordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("updateCounter")] 
		public CInt32 UpdateCounter
		{
			get
			{
				if (_updateCounter == null)
				{
					_updateCounter = (CInt32) CR2WTypeManager.Create("Int32", "updateCounter", cr2w, this);
				}
				return _updateCounter;
			}
			set
			{
				if (_updateCounter == value)
				{
					return;
				}
				_updateCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("boolsAsFlags")] 
		public CInt32 BoolsAsFlags
		{
			get
			{
				if (_boolsAsFlags == null)
				{
					_boolsAsFlags = (CInt32) CR2WTypeManager.Create("Int32", "boolsAsFlags", cr2w, this);
				}
				return _boolsAsFlags;
			}
			set
			{
				if (_boolsAsFlags == value)
				{
					return;
				}
				_boolsAsFlags = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("animBlendTime")] 
		public CFloat AnimBlendTime
		{
			get
			{
				if (_animBlendTime == null)
				{
					_animBlendTime = (CFloat) CR2WTypeManager.Create("Float", "animBlendTime", cr2w, this);
				}
				return _animBlendTime;
			}
			set
			{
				if (_animBlendTime == value)
				{
					return;
				}
				_animBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("forcedBlendIn")] 
		public CFloat ForcedBlendIn
		{
			get
			{
				if (_forcedBlendIn == null)
				{
					_forcedBlendIn = (CFloat) CR2WTypeManager.Create("Float", "forcedBlendIn", cr2w, this);
				}
				return _forcedBlendIn;
			}
			set
			{
				if (_forcedBlendIn == value)
				{
					return;
				}
				_forcedBlendIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("forceAnimTime")] 
		public CFloat ForceAnimTime
		{
			get
			{
				if (_forceAnimTime == null)
				{
					_forceAnimTime = (CFloat) CR2WTypeManager.Create("Float", "forceAnimTime", cr2w, this);
				}
				return _forceAnimTime;
			}
			set
			{
				if (_forceAnimTime == value)
				{
					return;
				}
				_forceAnimTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get
			{
				if (_timeScale == null)
				{
					_timeScale = (CFloat) CR2WTypeManager.Create("Float", "timeScale", cr2w, this);
				}
				return _timeScale;
			}
			set
			{
				if (_timeScale == value)
				{
					return;
				}
				_timeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("animationStartTime")] 
		public CDouble AnimationStartTime
		{
			get
			{
				if (_animationStartTime == null)
				{
					_animationStartTime = (CDouble) CR2WTypeManager.Create("Double", "animationStartTime", cr2w, this);
				}
				return _animationStartTime;
			}
			set
			{
				if (_animationStartTime == value)
				{
					return;
				}
				_animationStartTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get
			{
				if (_isPaused == null)
				{
					_isPaused = (CBool) CR2WTypeManager.Create("Bool", "isPaused", cr2w, this);
				}
				return _isPaused;
			}
			set
			{
				if (_isPaused == value)
				{
					return;
				}
				_isPaused = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get
			{
				if (_isLooped == null)
				{
					_isLooped = (CBool) CR2WTypeManager.Create("Bool", "isLooped", cr2w, this);
				}
				return _isLooped;
			}
			set
			{
				if (_isLooped == value)
				{
					return;
				}
				_isLooped = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isExitAnim")] 
		public CBool IsExitAnim
		{
			get
			{
				if (_isExitAnim == null)
				{
					_isExitAnim = (CBool) CR2WTypeManager.Create("Bool", "isExitAnim", cr2w, this);
				}
				return _isExitAnim;
			}
			set
			{
				if (_isExitAnim == value)
				{
					return;
				}
				_isExitAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("enableMotion")] 
		public CBool EnableMotion
		{
			get
			{
				if (_enableMotion == null)
				{
					_enableMotion = (CBool) CR2WTypeManager.Create("Bool", "enableMotion", cr2w, this);
				}
				return _enableMotion;
			}
			set
			{
				if (_enableMotion == value)
				{
					return;
				}
				_enableMotion = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isAnimValid")] 
		public CBool IsAnimValid
		{
			get
			{
				if (_isAnimValid == null)
				{
					_isAnimValid = (CBool) CR2WTypeManager.Create("Bool", "isAnimValid", cr2w, this);
				}
				return _isAnimValid;
			}
			set
			{
				if (_isAnimValid == value)
				{
					return;
				}
				_isAnimValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("slotNameHash")] 
		public CInt32 SlotNameHash
		{
			get
			{
				if (_slotNameHash == null)
				{
					_slotNameHash = (CInt32) CR2WTypeManager.Create("Int32", "slotNameHash", cr2w, this);
				}
				return _slotNameHash;
			}
			set
			{
				if (_slotNameHash == value)
				{
					return;
				}
				_slotNameHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get
			{
				if (_facialKeyWeight == null)
				{
					_facialKeyWeight = (CFloat) CR2WTypeManager.Create("Float", "facialKeyWeight", cr2w, this);
				}
				return _facialKeyWeight;
			}
			set
			{
				if (_facialKeyWeight == value)
				{
					return;
				}
				_facialKeyWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("facialIdleAnimation")] 
		public CName FacialIdleAnimation
		{
			get
			{
				if (_facialIdleAnimation == null)
				{
					_facialIdleAnimation = (CName) CR2WTypeManager.Create("CName", "facialIdleAnimation", cr2w, this);
				}
				return _facialIdleAnimation;
			}
			set
			{
				if (_facialIdleAnimation == value)
				{
					return;
				}
				_facialIdleAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("facialIdleKeyAnimation")] 
		public CName FacialIdleKeyAnimation
		{
			get
			{
				if (_facialIdleKeyAnimation == null)
				{
					_facialIdleKeyAnimation = (CName) CR2WTypeManager.Create("CName", "facialIdleKeyAnimation", cr2w, this);
				}
				return _facialIdleKeyAnimation;
			}
			set
			{
				if (_facialIdleKeyAnimation == value)
				{
					return;
				}
				_facialIdleKeyAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("globalBlendDuration")] 
		public CFloat GlobalBlendDuration
		{
			get
			{
				if (_globalBlendDuration == null)
				{
					_globalBlendDuration = (CFloat) CR2WTypeManager.Create("Float", "globalBlendDuration", cr2w, this);
				}
				return _globalBlendDuration;
			}
			set
			{
				if (_globalBlendDuration == value)
				{
					return;
				}
				_globalBlendDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("globalBlendIn")] 
		public CBool GlobalBlendIn
		{
			get
			{
				if (_globalBlendIn == null)
				{
					_globalBlendIn = (CBool) CR2WTypeManager.Create("Bool", "globalBlendIn", cr2w, this);
				}
				return _globalBlendIn;
			}
			set
			{
				if (_globalBlendIn == value)
				{
					return;
				}
				_globalBlendIn = value;
				PropertySet(this);
			}
		}

		public animAnimFeatureUpdateWorkspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
