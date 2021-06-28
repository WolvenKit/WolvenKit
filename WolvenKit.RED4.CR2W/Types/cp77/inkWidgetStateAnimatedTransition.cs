using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetStateAnimatedTransition : CVariable
	{
		private CName _startState;
		private CName _endState;
		private CName _animationName;
		private inkanimPlaybackOptions _playbackOptions;

		[Ordinal(0)] 
		[RED("startState")] 
		public CName StartState
		{
			get => GetProperty(ref _startState);
			set => SetProperty(ref _startState, value);
		}

		[Ordinal(1)] 
		[RED("endState")] 
		public CName EndState
		{
			get => GetProperty(ref _endState);
			set => SetProperty(ref _endState, value);
		}

		[Ordinal(2)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(3)] 
		[RED("playbackOptions")] 
		public inkanimPlaybackOptions PlaybackOptions
		{
			get => GetProperty(ref _playbackOptions);
			set => SetProperty(ref _playbackOptions, value);
		}

		public inkWidgetStateAnimatedTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
