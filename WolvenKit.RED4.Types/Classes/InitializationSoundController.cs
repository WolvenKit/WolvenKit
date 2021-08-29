using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InitializationSoundController : inkWidgetLogicController
	{
		private CName _soundControlName;
		private CName _initializeSoundName;
		private CName _unitializeSoundName;

		[Ordinal(1)] 
		[RED("soundControlName")] 
		public CName SoundControlName
		{
			get => GetProperty(ref _soundControlName);
			set => SetProperty(ref _soundControlName, value);
		}

		[Ordinal(2)] 
		[RED("initializeSoundName")] 
		public CName InitializeSoundName
		{
			get => GetProperty(ref _initializeSoundName);
			set => SetProperty(ref _initializeSoundName, value);
		}

		[Ordinal(3)] 
		[RED("unitializeSoundName")] 
		public CName UnitializeSoundName
		{
			get => GetProperty(ref _unitializeSoundName);
			set => SetProperty(ref _unitializeSoundName, value);
		}
	}
}
