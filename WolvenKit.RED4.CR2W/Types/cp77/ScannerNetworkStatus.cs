using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerNetworkStatus : ScannerChunk
	{
		private CEnum<ScannerNetworkState> _networkStatus;

		[Ordinal(0)] 
		[RED("networkStatus")] 
		public CEnum<ScannerNetworkState> NetworkStatus
		{
			get
			{
				if (_networkStatus == null)
				{
					_networkStatus = (CEnum<ScannerNetworkState>) CR2WTypeManager.Create("ScannerNetworkState", "networkStatus", cr2w, this);
				}
				return _networkStatus;
			}
			set
			{
				if (_networkStatus == value)
				{
					return;
				}
				_networkStatus = value;
				PropertySet(this);
			}
		}

		public ScannerNetworkStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
