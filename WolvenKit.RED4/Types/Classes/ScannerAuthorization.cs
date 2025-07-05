using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerAuthorization : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("keycard")] 
		public CBool Keycard
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("password")] 
		public CBool Password
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScannerAuthorization()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
