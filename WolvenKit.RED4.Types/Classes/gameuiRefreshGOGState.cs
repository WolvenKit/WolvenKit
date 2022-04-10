using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRefreshGOGState : redEvent
	{
		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<gameOnlineSystemStatus> Status
		{
			get => GetPropertyValue<CEnum<gameOnlineSystemStatus>>();
			set => SetPropertyValue<CEnum<gameOnlineSystemStatus>>(value);
		}

		[Ordinal(1)] 
		[RED("error")] 
		public CEnum<gameOnlineSystemErrors> Error
		{
			get => GetPropertyValue<CEnum<gameOnlineSystemErrors>>();
			set => SetPropertyValue<CEnum<gameOnlineSystemErrors>>(value);
		}

		[Ordinal(2)] 
		[RED("registerURL")] 
		public CString RegisterURL
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("qrCodePNGBlob")] 
		public CArray<CUInt8> QrCodePNGBlob
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		public gameuiRefreshGOGState()
		{
			QrCodePNGBlob = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
