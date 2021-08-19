using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClimbEvents : LocomotionGroundEvents
	{
		private CArray<CHandle<entIKTargetAddEvent>> _ikHandEvents;
		private CBool _shouldIkHands;
		private CInt32 _framesDelayingAnimStart;

		[Ordinal(3)] 
		[RED("ikHandEvents")] 
		public CArray<CHandle<entIKTargetAddEvent>> IkHandEvents
		{
			get => GetProperty(ref _ikHandEvents);
			set => SetProperty(ref _ikHandEvents, value);
		}

		[Ordinal(4)] 
		[RED("shouldIkHands")] 
		public CBool ShouldIkHands
		{
			get => GetProperty(ref _shouldIkHands);
			set => SetProperty(ref _shouldIkHands, value);
		}

		[Ordinal(5)] 
		[RED("framesDelayingAnimStart")] 
		public CInt32 FramesDelayingAnimStart
		{
			get => GetProperty(ref _framesDelayingAnimStart);
			set => SetProperty(ref _framesDelayingAnimStart, value);
		}

		public ClimbEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
