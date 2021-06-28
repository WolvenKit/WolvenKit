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
			get => GetProperty(ref _entrypoint);
			set => SetProperty(ref _entrypoint, value);
		}

		[Ordinal(1)] 
		[RED("syncNodesVisited")] 
		public CArray<scnSyncNodeSignal> SyncNodesVisited
		{
			get => GetProperty(ref _syncNodesVisited);
			set => SetProperty(ref _syncNodesVisited, value);
		}

		[Ordinal(2)] 
		[RED("instanceHash")] 
		public CUInt64 InstanceHash
		{
			get => GetProperty(ref _instanceHash);
			set => SetProperty(ref _instanceHash, value);
		}

		[Ordinal(3)] 
		[RED("finishedOnServer")] 
		public CBool FinishedOnServer
		{
			get => GetProperty(ref _finishedOnServer);
			set => SetProperty(ref _finishedOnServer, value);
		}

		[Ordinal(4)] 
		[RED("finishedOnClient")] 
		public CBool FinishedOnClient
		{
			get => GetProperty(ref _finishedOnClient);
			set => SetProperty(ref _finishedOnClient, value);
		}

		public scnSceneSharedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
