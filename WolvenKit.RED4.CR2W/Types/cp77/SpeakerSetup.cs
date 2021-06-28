using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpeakerSetup : CVariable
	{
		private CEnum<ERadioStationList> _defaultMusic;
		private CEnum<ERadioStationList> _distractionMusic;
		private CFloat _range;
		private CName _glitchSFX;
		private CBool _useOnlyGlitchSFX;

		[Ordinal(0)] 
		[RED("defaultMusic")] 
		public CEnum<ERadioStationList> DefaultMusic
		{
			get => GetProperty(ref _defaultMusic);
			set => SetProperty(ref _defaultMusic, value);
		}

		[Ordinal(1)] 
		[RED("distractionMusic")] 
		public CEnum<ERadioStationList> DistractionMusic
		{
			get => GetProperty(ref _distractionMusic);
			set => SetProperty(ref _distractionMusic, value);
		}

		[Ordinal(2)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(3)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get => GetProperty(ref _glitchSFX);
			set => SetProperty(ref _glitchSFX, value);
		}

		[Ordinal(4)] 
		[RED("useOnlyGlitchSFX")] 
		public CBool UseOnlyGlitchSFX
		{
			get => GetProperty(ref _useOnlyGlitchSFX);
			set => SetProperty(ref _useOnlyGlitchSFX, value);
		}

		public SpeakerSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
