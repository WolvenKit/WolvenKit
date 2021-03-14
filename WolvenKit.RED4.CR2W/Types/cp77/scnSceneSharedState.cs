using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneSharedState : ISerializable
	{
		private CName _entrypoint;
		private CArray<scnSyncNodeSignal> _syncNodesVisited;
		private CUInt64 _instanceHash;
		private CBool _finishedOnServer;
		private CBool _finishedOnClient;

		[Ordinal(0)] 
		[RED("entrypoint")] 
		public CName Entrypoint
		{
			get
			{
				if (_entrypoint == null)
				{
					_entrypoint = (CName) CR2WTypeManager.Create("CName", "entrypoint", cr2w, this);
				}
				return _entrypoint;
			}
			set
			{
				if (_entrypoint == value)
				{
					return;
				}
				_entrypoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("syncNodesVisited")] 
		public CArray<scnSyncNodeSignal> SyncNodesVisited
		{
			get
			{
				if (_syncNodesVisited == null)
				{
					_syncNodesVisited = (CArray<scnSyncNodeSignal>) CR2WTypeManager.Create("array:scnSyncNodeSignal", "syncNodesVisited", cr2w, this);
				}
				return _syncNodesVisited;
			}
			set
			{
				if (_syncNodesVisited == value)
				{
					return;
				}
				_syncNodesVisited = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("instanceHash")] 
		public CUInt64 InstanceHash
		{
			get
			{
				if (_instanceHash == null)
				{
					_instanceHash = (CUInt64) CR2WTypeManager.Create("Uint64", "instanceHash", cr2w, this);
				}
				return _instanceHash;
			}
			set
			{
				if (_instanceHash == value)
				{
					return;
				}
				_instanceHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("finishedOnServer")] 
		public CBool FinishedOnServer
		{
			get
			{
				if (_finishedOnServer == null)
				{
					_finishedOnServer = (CBool) CR2WTypeManager.Create("Bool", "finishedOnServer", cr2w, this);
				}
				return _finishedOnServer;
			}
			set
			{
				if (_finishedOnServer == value)
				{
					return;
				}
				_finishedOnServer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("finishedOnClient")] 
		public CBool FinishedOnClient
		{
			get
			{
				if (_finishedOnClient == null)
				{
					_finishedOnClient = (CBool) CR2WTypeManager.Create("Bool", "finishedOnClient", cr2w, this);
				}
				return _finishedOnClient;
			}
			set
			{
				if (_finishedOnClient == value)
				{
					return;
				}
				_finishedOnClient = value;
				PropertySet(this);
			}
		}

		public scnSceneSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
