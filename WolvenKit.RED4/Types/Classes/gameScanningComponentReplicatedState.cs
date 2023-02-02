using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameScanningComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get => GetPropertyValue<CEnum<gameScanningState>>();
			set => SetPropertyValue<CEnum<gameScanningState>>(value);
		}

		[Ordinal(3)] 
		[RED("pctScanned")] 
		public CFloat PctScanned
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("controllingPeerIDs", 8)] 
		public CStatic<netPeerID> ControllingPeerIDs
		{
			get => GetPropertyValue<CStatic<netPeerID>>();
			set => SetPropertyValue<CStatic<netPeerID>>(value);
		}

		public gameScanningComponentReplicatedState()
		{
			Enabled = true;
			ControllingPeerIDs = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
