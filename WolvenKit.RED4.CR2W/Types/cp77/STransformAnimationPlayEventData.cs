using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STransformAnimationPlayEventData : CVariable
	{
		private CFloat _timeScale;
		private CBool _looping;
		private CUInt32 _timesPlayed;

		[Ordinal(0)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetProperty(ref _timeScale);
			set => SetProperty(ref _timeScale, value);
		}

		[Ordinal(1)] 
		[RED("looping")] 
		public CBool Looping
		{
			get => GetProperty(ref _looping);
			set => SetProperty(ref _looping, value);
		}

		[Ordinal(2)] 
		[RED("timesPlayed")] 
		public CUInt32 TimesPlayed
		{
			get => GetProperty(ref _timesPlayed);
			set => SetProperty(ref _timesPlayed, value);
		}

		public STransformAnimationPlayEventData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
