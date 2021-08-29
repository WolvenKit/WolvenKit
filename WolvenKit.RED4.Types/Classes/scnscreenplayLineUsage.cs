using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnscreenplayLineUsage : RedBaseClass
	{
		private scnGenderMask _playerGenderMask;

		[Ordinal(0)] 
		[RED("playerGenderMask")] 
		public scnGenderMask PlayerGenderMask
		{
			get => GetProperty(ref _playerGenderMask);
			set => SetProperty(ref _playerGenderMask, value);
		}
	}
}
