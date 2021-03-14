using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDeviceBaseReplicationProxy : netIEntityState
	{
		private CHandle<gameDeviceReplicatedState> _scriptState;
		private CUInt32 _versionId;
		private netTime _versionTimestamp;
		private EulerAngles _initialOrientation;
		private Vector3 _initialLocation;

		[Ordinal(2)] 
		[RED("scriptState")] 
		public CHandle<gameDeviceReplicatedState> ScriptState
		{
			get
			{
				if (_scriptState == null)
				{
					_scriptState = (CHandle<gameDeviceReplicatedState>) CR2WTypeManager.Create("handle:gameDeviceReplicatedState", "scriptState", cr2w, this);
				}
				return _scriptState;
			}
			set
			{
				if (_scriptState == value)
				{
					return;
				}
				_scriptState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("versionId")] 
		public CUInt32 VersionId
		{
			get
			{
				if (_versionId == null)
				{
					_versionId = (CUInt32) CR2WTypeManager.Create("Uint32", "versionId", cr2w, this);
				}
				return _versionId;
			}
			set
			{
				if (_versionId == value)
				{
					return;
				}
				_versionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("versionTimestamp")] 
		public netTime VersionTimestamp
		{
			get
			{
				if (_versionTimestamp == null)
				{
					_versionTimestamp = (netTime) CR2WTypeManager.Create("netTime", "versionTimestamp", cr2w, this);
				}
				return _versionTimestamp;
			}
			set
			{
				if (_versionTimestamp == value)
				{
					return;
				}
				_versionTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("initialOrientation")] 
		public EulerAngles InitialOrientation
		{
			get
			{
				if (_initialOrientation == null)
				{
					_initialOrientation = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "initialOrientation", cr2w, this);
				}
				return _initialOrientation;
			}
			set
			{
				if (_initialOrientation == value)
				{
					return;
				}
				_initialOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("initialLocation")] 
		public Vector3 InitialLocation
		{
			get
			{
				if (_initialLocation == null)
				{
					_initialLocation = (Vector3) CR2WTypeManager.Create("Vector3", "initialLocation", cr2w, this);
				}
				return _initialLocation;
			}
			set
			{
				if (_initialLocation == value)
				{
					return;
				}
				_initialLocation = value;
				PropertySet(this);
			}
		}

		public gameDeviceBaseReplicationProxy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
