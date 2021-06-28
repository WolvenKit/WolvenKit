using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWidgetAnimationData : CVariable
	{
		private CName _animationName;
		private inkanimPlaybackOptions _playbackOptions;
		private CBool _lockWhenActive;
		private CHandle<inkanimProxy> _animProxy;
		private CName _onFinish;
		private CName _onStart;
		private CName _onPasue;
		private CName _onResume;
		private CName _onStartLoop;
		private CName _onEndLoop;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(1)] 
		[RED("playbackOptions")] 
		public inkanimPlaybackOptions PlaybackOptions
		{
			get => GetProperty(ref _playbackOptions);
			set => SetProperty(ref _playbackOptions, value);
		}

		[Ordinal(2)] 
		[RED("lockWhenActive")] 
		public CBool LockWhenActive
		{
			get => GetProperty(ref _lockWhenActive);
			set => SetProperty(ref _lockWhenActive, value);
		}

		[Ordinal(3)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(4)] 
		[RED("onFinish")] 
		public CName OnFinish
		{
			get => GetProperty(ref _onFinish);
			set => SetProperty(ref _onFinish, value);
		}

		[Ordinal(5)] 
		[RED("onStart")] 
		public CName OnStart
		{
			get => GetProperty(ref _onStart);
			set => SetProperty(ref _onStart, value);
		}

		[Ordinal(6)] 
		[RED("onPasue")] 
		public CName OnPasue
		{
			get => GetProperty(ref _onPasue);
			set => SetProperty(ref _onPasue, value);
		}

		[Ordinal(7)] 
		[RED("onResume")] 
		public CName OnResume
		{
			get => GetProperty(ref _onResume);
			set => SetProperty(ref _onResume, value);
		}

		[Ordinal(8)] 
		[RED("onStartLoop")] 
		public CName OnStartLoop
		{
			get => GetProperty(ref _onStartLoop);
			set => SetProperty(ref _onStartLoop, value);
		}

		[Ordinal(9)] 
		[RED("onEndLoop")] 
		public CName OnEndLoop
		{
			get => GetProperty(ref _onEndLoop);
			set => SetProperty(ref _onEndLoop, value);
		}

		public SWidgetAnimationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
