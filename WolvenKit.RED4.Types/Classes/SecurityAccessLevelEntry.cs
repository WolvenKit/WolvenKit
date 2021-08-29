using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAccessLevelEntry : RedBaseClass
	{
		private TweakDBID _keycard;
		private CName _password;

		[Ordinal(0)] 
		[RED("keycard")] 
		public TweakDBID Keycard
		{
			get => GetProperty(ref _keycard);
			set => SetProperty(ref _keycard, value);
		}

		[Ordinal(1)] 
		[RED("password")] 
		public CName Password
		{
			get => GetProperty(ref _password);
			set => SetProperty(ref _password, value);
		}
	}
}
