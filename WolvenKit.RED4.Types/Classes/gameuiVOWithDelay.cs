using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiVOWithDelay : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("playDelay")] 
		public CFloat PlayDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("voHexID")] 
		public CString VoHexID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gameuiVOWithDelay()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
