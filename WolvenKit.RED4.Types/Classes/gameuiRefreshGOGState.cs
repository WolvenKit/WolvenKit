using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRefreshGOGState : redEvent
	{
		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<gameGOGRewardsSystemStatus> Status
		{
			get => GetPropertyValue<CEnum<gameGOGRewardsSystemStatus>>();
			set => SetPropertyValue<CEnum<gameGOGRewardsSystemStatus>>(value);
		}

		[Ordinal(1)] 
		[RED("error")] 
		public CEnum<gameGOGRewardsSystemErrors> Error
		{
			get => GetPropertyValue<CEnum<gameGOGRewardsSystemErrors>>();
			set => SetPropertyValue<CEnum<gameGOGRewardsSystemErrors>>(value);
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
		}
	}
}
