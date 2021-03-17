using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionAdjusterOnEvent : animAnimNode_LocomotionAdjuster
	{
		private CName _locomotionFeatureName;
		private CName _targetAnimationName;
		private CName _startAdjustmentAfterAnimEvent;

		[Ordinal(19)] 
		[RED("locomotionFeatureName")] 
		public CName LocomotionFeatureName
		{
			get => GetProperty(ref _locomotionFeatureName);
			set => SetProperty(ref _locomotionFeatureName, value);
		}

		[Ordinal(20)] 
		[RED("targetAnimationName")] 
		public CName TargetAnimationName
		{
			get => GetProperty(ref _targetAnimationName);
			set => SetProperty(ref _targetAnimationName, value);
		}

		[Ordinal(21)] 
		[RED("startAdjustmentAfterAnimEvent")] 
		public CName StartAdjustmentAfterAnimEvent
		{
			get => GetProperty(ref _startAdjustmentAfterAnimEvent);
			set => SetProperty(ref _startAdjustmentAfterAnimEvent, value);
		}

		public animAnimNode_LocomotionAdjusterOnEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
