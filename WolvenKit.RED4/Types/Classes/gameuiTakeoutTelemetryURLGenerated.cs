using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTakeoutTelemetryURLGenerated : redEvent
	{
		[Ordinal(0)] 
		[RED("takeoutURL")] 
		public CString TakeoutURL
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("qrCodePNGBlob")] 
		public CArray<CUInt8> QrCodePNGBlob
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		public gameuiTakeoutTelemetryURLGenerated()
		{
			QrCodePNGBlob = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
