using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionAnimationState : gameActionReplicatedState
	{
		private CName _animFeatureName;
		private CHandle<animAnimFeature_AIAction> _animFeature;
		private CBool _useRootMotion;
		private CBool _usePoseMatching;
		private CBool _motionDynamicObjectsCheck;
		private gameActionAnimationSlideParams _slideParams;
		private wCHandle<gameObject> _targetObject;
		private CBool _sendLoopEvent;

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature_AIAction> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<animAnimFeature_AIAction>) CR2WTypeManager.Create("handle:animAnimFeature_AIAction", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("useRootMotion")] 
		public CBool UseRootMotion
		{
			get
			{
				if (_useRootMotion == null)
				{
					_useRootMotion = (CBool) CR2WTypeManager.Create("Bool", "useRootMotion", cr2w, this);
				}
				return _useRootMotion;
			}
			set
			{
				if (_useRootMotion == value)
				{
					return;
				}
				_useRootMotion = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("usePoseMatching")] 
		public CBool UsePoseMatching
		{
			get
			{
				if (_usePoseMatching == null)
				{
					_usePoseMatching = (CBool) CR2WTypeManager.Create("Bool", "usePoseMatching", cr2w, this);
				}
				return _usePoseMatching;
			}
			set
			{
				if (_usePoseMatching == value)
				{
					return;
				}
				_usePoseMatching = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("motionDynamicObjectsCheck")] 
		public CBool MotionDynamicObjectsCheck
		{
			get
			{
				if (_motionDynamicObjectsCheck == null)
				{
					_motionDynamicObjectsCheck = (CBool) CR2WTypeManager.Create("Bool", "motionDynamicObjectsCheck", cr2w, this);
				}
				return _motionDynamicObjectsCheck;
			}
			set
			{
				if (_motionDynamicObjectsCheck == value)
				{
					return;
				}
				_motionDynamicObjectsCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("slideParams")] 
		public gameActionAnimationSlideParams SlideParams
		{
			get
			{
				if (_slideParams == null)
				{
					_slideParams = (gameActionAnimationSlideParams) CR2WTypeManager.Create("gameActionAnimationSlideParams", "slideParams", cr2w, this);
				}
				return _slideParams;
			}
			set
			{
				if (_slideParams == value)
				{
					return;
				}
				_slideParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("targetObject")] 
		public wCHandle<gameObject> TargetObject
		{
			get
			{
				if (_targetObject == null)
				{
					_targetObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetObject", cr2w, this);
				}
				return _targetObject;
			}
			set
			{
				if (_targetObject == value)
				{
					return;
				}
				_targetObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("sendLoopEvent")] 
		public CBool SendLoopEvent
		{
			get
			{
				if (_sendLoopEvent == null)
				{
					_sendLoopEvent = (CBool) CR2WTypeManager.Create("Bool", "sendLoopEvent", cr2w, this);
				}
				return _sendLoopEvent;
			}
			set
			{
				if (_sendLoopEvent == value)
				{
					return;
				}
				_sendLoopEvent = value;
				PropertySet(this);
			}
		}

		public gameActionAnimationState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
