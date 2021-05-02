using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationSkipEvent : gameTransformAnimationEvent
	{
		private CFloat _time;
		private CBool _skipToEnd;
		private CBool _forcePlay;

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(2)] 
		[RED("skipToEnd")] 
		public CBool SkipToEnd
		{
			get => GetProperty(ref _skipToEnd);
			set => SetProperty(ref _skipToEnd, value);
		}

		[Ordinal(3)] 
		[RED("forcePlay")] 
		public CBool ForcePlay
		{
			get => GetProperty(ref _forcePlay);
			set => SetProperty(ref _forcePlay, value);
		}

		public gameTransformAnimationSkipEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
