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
			get
			{
				if (_scanningState == null)
				{
					_scanningState = (CEnum<gameScanningState>) CR2WTypeManager.Create("gameScanningState", "scanningState", cr2w, this);
				}
				return _scanningState;
			}
			set
			{
				if (_scanningState == value)
				{
					return;
				}
				_scanningState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pctScanned")] 
		public CFloat PctScanned
		{
			get
			{
				if (_pctScanned == null)
				{
					_pctScanned = (CFloat) CR2WTypeManager.Create("Float", "pctScanned", cr2w, this);
				}
				return _pctScanned;
			}
			set
			{
				if (_pctScanned == value)
				{
					return;
				}
				_pctScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("controllingPeerIDs", 8)] 
		public CStatic<netPeerID> ControllingPeerIDs
		{
			get
			{
				if (_controllingPeerIDs == null)
				{
					_controllingPeerIDs = (CStatic<netPeerID>) CR2WTypeManager.Create("static:8,netPeerID", "controllingPeerIDs", cr2w, this);
				}
				return _controllingPeerIDs;
			}
			set
			{
				if (_controllingPeerIDs == value)
				{
					return;
				}
				_controllingPeerIDs = value;
				PropertySet(this);
			}
		}

		public gameScanningComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
