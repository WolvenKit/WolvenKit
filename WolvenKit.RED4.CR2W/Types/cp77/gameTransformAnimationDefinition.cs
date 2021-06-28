using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationDefinition : CVariable
	{
		private CName _name;
		private CBool _autoStart;
		private CFloat _autoStartDelay;
		private CUInt32 _timesToPlay;
		private CBool _looping;
		private CFloat _timeScale;
		private CBool _reverse;
		private gameTransformAnimationTimeline _timeline;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("autoStart")] 
		public CBool AutoStart
		{
			get => GetProperty(ref _autoStart);
			set => SetProperty(ref _autoStart, value);
		}

		[Ordinal(2)] 
		[RED("autoStartDelay")] 
		public CFloat AutoStartDelay
		{
			get => GetProperty(ref _autoStartDelay);
			set => SetProperty(ref _autoStartDelay, value);
		}

		[Ordinal(3)] 
		[RED("timesToPlay")] 
		public CUInt32 TimesToPlay
		{
			get => GetProperty(ref _timesToPlay);
			set => SetProperty(ref _timesToPlay, value);
		}

		[Ordinal(4)] 
		[RED("looping")] 
		public CBool Looping
		{
			get => GetProperty(ref _looping);
			set => SetProperty(ref _looping, value);
		}

		[Ordinal(5)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetProperty(ref _timeScale);
			set => SetProperty(ref _timeScale, value);
		}

		[Ordinal(6)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get => GetProperty(ref _reverse);
			set => SetProperty(ref _reverse, value);
		}

		[Ordinal(7)] 
		[RED("timeline")] 
		public gameTransformAnimationTimeline Timeline
		{
			get => GetProperty(ref _timeline);
			set => SetProperty(ref _timeline, value);
		}

		public gameTransformAnimationDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
