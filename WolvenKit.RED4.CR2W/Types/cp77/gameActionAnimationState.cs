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
			get => GetProperty(ref _animFeatureName);
			set => SetProperty(ref _animFeatureName, value);
		}

		[Ordinal(6)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature_AIAction> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(7)] 
		[RED("useRootMotion")] 
		public CBool UseRootMotion
		{
			get => GetProperty(ref _useRootMotion);
			set => SetProperty(ref _useRootMotion, value);
		}

		[Ordinal(8)] 
		[RED("usePoseMatching")] 
		public CBool UsePoseMatching
		{
			get => GetProperty(ref _usePoseMatching);
			set => SetProperty(ref _usePoseMatching, value);
		}

		[Ordinal(9)] 
		[RED("motionDynamicObjectsCheck")] 
		public CBool MotionDynamicObjectsCheck
		{
			get => GetProperty(ref _motionDynamicObjectsCheck);
			set => SetProperty(ref _motionDynamicObjectsCheck, value);
		}

		[Ordinal(10)] 
		[RED("slideParams")] 
		public gameActionAnimationSlideParams SlideParams
		{
			get => GetProperty(ref _slideParams);
			set => SetProperty(ref _slideParams, value);
		}

		[Ordinal(11)] 
		[RED("targetObject")] 
		public wCHandle<gameObject> TargetObject
		{
			get => GetProperty(ref _targetObject);
			set => SetProperty(ref _targetObject, value);
		}

		[Ordinal(12)] 
		[RED("sendLoopEvent")] 
		public CBool SendLoopEvent
		{
			get => GetProperty(ref _sendLoopEvent);
			set => SetProperty(ref _sendLoopEvent, value);
		}

		public gameActionAnimationState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
