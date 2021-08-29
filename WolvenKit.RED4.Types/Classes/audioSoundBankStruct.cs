using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioSoundBankStruct : RedBaseClass
	{
		private CName _soundBank;

		[Ordinal(0)] 
		[RED("soundBank")] 
		public CName SoundBank
		{
			get => GetProperty(ref _soundBank);
			set => SetProperty(ref _soundBank, value);
		}
	}
}
