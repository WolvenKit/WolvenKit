using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ButtonPlaySoundView : BaseButtonView
	{
		private CName _soundPrefix;
		private CName _pressSoundName;
		private CName _hoverSoundName;

		[Ordinal(2)] 
		[RED("SoundPrefix")] 
		public CName SoundPrefix
		{
			get => GetProperty(ref _soundPrefix);
			set => SetProperty(ref _soundPrefix, value);
		}

		[Ordinal(3)] 
		[RED("PressSoundName")] 
		public CName PressSoundName
		{
			get => GetProperty(ref _pressSoundName);
			set => SetProperty(ref _pressSoundName, value);
		}

		[Ordinal(4)] 
		[RED("HoverSoundName")] 
		public CName HoverSoundName
		{
			get => GetProperty(ref _hoverSoundName);
			set => SetProperty(ref _hoverSoundName, value);
		}

		public ButtonPlaySoundView()
		{
			_soundPrefix = "Button";
			_pressSoundName = "OnPress";
		}
	}
}
