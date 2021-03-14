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
			get
			{
				if (_status == null)
				{
					_status = (CEnum<gameGOGRewardsSystemStatus>) CR2WTypeManager.Create("gameGOGRewardsSystemStatus", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("error")] 
		public CEnum<gameGOGRewardsSystemErrors> Error
		{
			get
			{
				if (_error == null)
				{
					_error = (CEnum<gameGOGRewardsSystemErrors>) CR2WTypeManager.Create("gameGOGRewardsSystemErrors", "error", cr2w, this);
				}
				return _error;
			}
			set
			{
				if (_error == value)
				{
					return;
				}
				_error = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("registerURL")] 
		public CString RegisterURL
		{
			get
			{
				if (_registerURL == null)
				{
					_registerURL = (CString) CR2WTypeManager.Create("String", "registerURL", cr2w, this);
				}
				return _registerURL;
			}
			set
			{
				if (_registerURL == value)
				{
					return;
				}
				_registerURL = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("qrCodePNGBlob")] 
		public CArray<CUInt8> QrCodePNGBlob
		{
			get
			{
				if (_qrCodePNGBlob == null)
				{
					_qrCodePNGBlob = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "qrCodePNGBlob", cr2w, this);
				}
				return _qrCodePNGBlob;
			}
			set
			{
				if (_qrCodePNGBlob == value)
				{
					return;
				}
				_qrCodePNGBlob = value;
				PropertySet(this);
			}
		}

		public gameuiRefreshGOGState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
