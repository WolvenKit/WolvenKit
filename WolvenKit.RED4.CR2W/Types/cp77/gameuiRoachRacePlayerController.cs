using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRacePlayerController : gameuiSideScrollerMiniGamePlayerController
	{
		private CName _runAnimation;
		private CName _jumpAnimation;
		private CHandle<inkanimProxy> _currentAnimation;

		[Ordinal(1)] 
		[RED("runAnimation")] 
		public CName RunAnimation
		{
			get => GetProperty(ref _runAnimation);
			set => SetProperty(ref _runAnimation, value);
		}

		[Ordinal(2)] 
		[RED("jumpAnimation")] 
		public CName JumpAnimation
		{
			get => GetProperty(ref _jumpAnimation);
			set => SetProperty(ref _jumpAnimation, value);
		}

		[Ordinal(3)] 
		[RED("currentAnimation")] 
		public CHandle<inkanimProxy> CurrentAnimation
		{
			get => GetProperty(ref _currentAnimation);
			set => SetProperty(ref _currentAnimation, value);
		}

		public gameuiRoachRacePlayerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
