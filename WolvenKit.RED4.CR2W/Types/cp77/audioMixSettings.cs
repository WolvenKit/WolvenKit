using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMixSettings : audioAudioMetadata
	{
		private CFloat _masterVolume;
		private CFloat _sfxVolume;
		private CFloat _musicVolume;
		private CFloat _voVolume;
		private CFloat _uiMenuVolume;
		private CName _onStartupEvent;

		[Ordinal(1)] 
		[RED("masterVolume")] 
		public CFloat MasterVolume
		{
			get => GetProperty(ref _masterVolume);
			set => SetProperty(ref _masterVolume, value);
		}

		[Ordinal(2)] 
		[RED("sfxVolume")] 
		public CFloat SfxVolume
		{
			get => GetProperty(ref _sfxVolume);
			set => SetProperty(ref _sfxVolume, value);
		}

		[Ordinal(3)] 
		[RED("musicVolume")] 
		public CFloat MusicVolume
		{
			get => GetProperty(ref _musicVolume);
			set => SetProperty(ref _musicVolume, value);
		}

		[Ordinal(4)] 
		[RED("voVolume")] 
		public CFloat VoVolume
		{
			get => GetProperty(ref _voVolume);
			set => SetProperty(ref _voVolume, value);
		}

		[Ordinal(5)] 
		[RED("uiMenuVolume")] 
		public CFloat UiMenuVolume
		{
			get => GetProperty(ref _uiMenuVolume);
			set => SetProperty(ref _uiMenuVolume, value);
		}

		[Ordinal(6)] 
		[RED("onStartupEvent")] 
		public CName OnStartupEvent
		{
			get => GetProperty(ref _onStartupEvent);
			set => SetProperty(ref _onStartupEvent, value);
		}

		public audioMixSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
