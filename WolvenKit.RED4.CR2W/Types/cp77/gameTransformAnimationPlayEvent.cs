using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationPlayEvent : gameTransformAnimationEvent
	{
		private CFloat _timeScale;
		private CBool _looping;
		private CUInt32 _timesPlayed;
		private CBool _useEntitySetup;

		[Ordinal(1)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetProperty(ref _timeScale);
			set => SetProperty(ref _timeScale, value);
		}

		[Ordinal(2)] 
		[RED("looping")] 
		public CBool Looping
		{
			get => GetProperty(ref _looping);
			set => SetProperty(ref _looping, value);
		}

		[Ordinal(3)] 
		[RED("timesPlayed")] 
		public CUInt32 TimesPlayed
		{
			get => GetProperty(ref _timesPlayed);
			set => SetProperty(ref _timesPlayed, value);
		}

		[Ordinal(4)] 
		[RED("useEntitySetup")] 
		public CBool UseEntitySetup
		{
			get => GetProperty(ref _useEntitySetup);
			set => SetProperty(ref _useEntitySetup, value);
		}

		public gameTransformAnimationPlayEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
