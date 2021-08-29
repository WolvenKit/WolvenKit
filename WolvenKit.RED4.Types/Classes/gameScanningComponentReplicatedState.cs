using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningComponentReplicatedState : netIComponentState
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
	}
}
