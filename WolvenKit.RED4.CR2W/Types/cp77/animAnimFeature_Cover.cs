using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Cover : animAnimFeature
	{
		private Vector4 _coverPosition;
		private Vector4 _coverDirection;
		private CInt32 _coverState;
		private CFloat _coverAngleToAction;
		private CInt32 _stance;
		private CInt32 _behavior;
		private CInt32 _coverAction;
		private CFloat _behaviorTime_PreAction;
		private CFloat _behaviorTime_Action;
		private CFloat _behaviorTime_PostAction;

		[Ordinal(0)] 
		[RED("coverPosition")] 
		public Vector4 CoverPosition
		{
			get => GetProperty(ref _coverPosition);
			set => SetProperty(ref _coverPosition, value);
		}

		[Ordinal(1)] 
		[RED("coverDirection")] 
		public Vector4 CoverDirection
		{
			get => GetProperty(ref _coverDirection);
			set => SetProperty(ref _coverDirection, value);
		}

		[Ordinal(2)] 
		[RED("coverState")] 
		public CInt32 CoverState
		{
			get => GetProperty(ref _coverState);
			set => SetProperty(ref _coverState, value);
		}

		[Ordinal(3)] 
		[RED("coverAngleToAction")] 
		public CFloat CoverAngleToAction
		{
			get => GetProperty(ref _coverAngleToAction);
			set => SetProperty(ref _coverAngleToAction, value);
		}

		[Ordinal(4)] 
		[RED("stance")] 
		public CInt32 Stance
		{
			get => GetProperty(ref _stance);
			set => SetProperty(ref _stance, value);
		}

		[Ordinal(5)] 
		[RED("behavior")] 
		public CInt32 Behavior
		{
			get => GetProperty(ref _behavior);
			set => SetProperty(ref _behavior, value);
		}

		[Ordinal(6)] 
		[RED("coverAction")] 
		public CInt32 CoverAction
		{
			get => GetProperty(ref _coverAction);
			set => SetProperty(ref _coverAction, value);
		}

		[Ordinal(7)] 
		[RED("behaviorTime_PreAction")] 
		public CFloat BehaviorTime_PreAction
		{
			get => GetProperty(ref _behaviorTime_PreAction);
			set => SetProperty(ref _behaviorTime_PreAction, value);
		}

		[Ordinal(8)] 
		[RED("behaviorTime_Action")] 
		public CFloat BehaviorTime_Action
		{
			get => GetProperty(ref _behaviorTime_Action);
			set => SetProperty(ref _behaviorTime_Action, value);
		}

		[Ordinal(9)] 
		[RED("behaviorTime_PostAction")] 
		public CFloat BehaviorTime_PostAction
		{
			get => GetProperty(ref _behaviorTime_PostAction);
			set => SetProperty(ref _behaviorTime_PostAction, value);
		}

		public animAnimFeature_Cover(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
