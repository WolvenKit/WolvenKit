using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimation_PlaySound : gameTransformAnimationTrackItemImpl
	{
		private CName _soundName;
		private CBool _unique;

		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetProperty(ref _soundName);
			set => SetProperty(ref _soundName, value);
		}

		[Ordinal(1)] 
		[RED("unique")] 
		public CBool Unique
		{
			get => GetProperty(ref _unique);
			set => SetProperty(ref _unique, value);
		}
	}
}
