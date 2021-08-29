using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerAuthorization : ScannerChunk
	{
		private CBool _keycard;
		private CBool _password;

		[Ordinal(0)] 
		[RED("keycard")] 
		public CBool Keycard
		{
			get => GetProperty(ref _keycard);
			set => SetProperty(ref _keycard, value);
		}

		[Ordinal(1)] 
		[RED("password")] 
		public CBool Password
		{
			get => GetProperty(ref _password);
			set => SetProperty(ref _password, value);
		}
	}
}
