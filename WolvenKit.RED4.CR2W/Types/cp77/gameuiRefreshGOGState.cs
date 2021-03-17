using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRefreshGOGState : redEvent
	{
		private CEnum<gameGOGRewardsSystemStatus> _status;
		private CEnum<gameGOGRewardsSystemErrors> _error;
		private CString _registerURL;
		private CArray<CUInt8> _qrCodePNGBlob;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<gameGOGRewardsSystemStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(1)] 
		[RED("error")] 
		public CEnum<gameGOGRewardsSystemErrors> Error
		{
			get => GetProperty(ref _error);
			set => SetProperty(ref _error, value);
		}

		[Ordinal(2)] 
		[RED("registerURL")] 
		public CString RegisterURL
		{
			get => GetProperty(ref _registerURL);
			set => SetProperty(ref _registerURL, value);
		}

		[Ordinal(3)] 
		[RED("qrCodePNGBlob")] 
		public CArray<CUInt8> QrCodePNGBlob
		{
			get => GetProperty(ref _qrCodePNGBlob);
			set => SetProperty(ref _qrCodePNGBlob, value);
		}

		public gameuiRefreshGOGState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
