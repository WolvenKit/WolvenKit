using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneSharedState : ISerializable
	{
		[Ordinal(0)] 
		[RED("entrypoint")] 
		public CName Entrypoint
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("syncNodesVisited")] 
		public CArray<scnSyncNodeSignal> SyncNodesVisited
		{
			get => GetPropertyValue<CArray<scnSyncNodeSignal>>();
			set => SetPropertyValue<CArray<scnSyncNodeSignal>>(value);
		}

		[Ordinal(2)] 
		[RED("instanceHash")] 
		public CUInt64 InstanceHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("finishedOnServer")] 
		public CBool FinishedOnServer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("finishedOnClient")] 
		public CBool FinishedOnClient
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnSceneSharedState()
		{
			SyncNodesVisited = new();
			InstanceHash = 6242570315725555409;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
