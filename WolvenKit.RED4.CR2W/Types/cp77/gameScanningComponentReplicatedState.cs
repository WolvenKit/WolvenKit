using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponentReplicatedState : netIComponentState
	{
		private CEnum<gameScanningState> _scanningState;
		private CFloat _pctScanned;
		private CStatic<netPeerID> _controllingPeerIDs;

		[Ordinal(2)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get => GetProperty(ref _scanningState);
			set => SetProperty(ref _scanningState, value);
		}

		[Ordinal(3)] 
		[RED("pctScanned")] 
		public CFloat PctScanned
		{
			get => GetProperty(ref _pctScanned);
			set => SetProperty(ref _pctScanned, value);
		}

		[Ordinal(4)] 
		[RED("controllingPeerIDs", 8)] 
		public CStatic<netPeerID> ControllingPeerIDs
		{
			get => GetProperty(ref _controllingPeerIDs);
			set => SetProperty(ref _controllingPeerIDs, value);
		}

		public gameScanningComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
