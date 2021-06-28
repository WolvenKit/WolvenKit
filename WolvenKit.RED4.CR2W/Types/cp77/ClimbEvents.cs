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

		[Ordinal(0)] 
		[RED("ikHandEvents")] 
		public CArray<CHandle<entIKTargetAddEvent>> IkHandEvents
		{
			get => GetProperty(ref _ikHandEvents);
			set => SetProperty(ref _ikHandEvents, value);
		}

		[Ordinal(1)] 
		[RED("shouldIkHands")] 
		public CBool ShouldIkHands
		{
			get => GetProperty(ref _shouldIkHands);
			set => SetProperty(ref _shouldIkHands, value);
		}

		public ClimbEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
