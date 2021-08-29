using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceTagAppearanceGroup : RedBaseClass
	{
		private CArray<CName> _appearances;
		private CArray<CName> _voicetags;

		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(1)] 
		[RED("voicetags")] 
		public CArray<CName> Voicetags
		{
			get => GetProperty(ref _voicetags);
			set => SetProperty(ref _voicetags, value);
		}
	}
}
