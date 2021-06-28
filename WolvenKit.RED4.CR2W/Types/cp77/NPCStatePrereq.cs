using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCStatePrereq : gameIScriptablePrereq
	{
		private CBool _previousState;
		private CBool _isInState;
		private CBool _skipWhenApplied;

		[Ordinal(0)] 
		[RED("previousState")] 
		public CBool PreviousState
		{
			get => GetProperty(ref _previousState);
			set => SetProperty(ref _previousState, value);
		}

		[Ordinal(1)] 
		[RED("isInState")] 
		public CBool IsInState
		{
			get => GetProperty(ref _isInState);
			set => SetProperty(ref _isInState, value);
		}

		[Ordinal(2)] 
		[RED("skipWhenApplied")] 
		public CBool SkipWhenApplied
		{
			get => GetProperty(ref _skipWhenApplied);
			set => SetProperty(ref _skipWhenApplied, value);
		}

		public NPCStatePrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
