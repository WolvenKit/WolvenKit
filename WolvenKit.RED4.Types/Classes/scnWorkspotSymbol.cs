using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnWorkspotSymbol : RedBaseClass
	{
		private scnSceneWorkspotInstanceId _wsInstance;
		private scnNodeId _wsNodeId;
		private CUInt64 _wsEditorEventId;

		[Ordinal(0)] 
		[RED("wsInstance")] 
		public scnSceneWorkspotInstanceId WsInstance
		{
			get => GetProperty(ref _wsInstance);
			set => SetProperty(ref _wsInstance, value);
		}

		[Ordinal(1)] 
		[RED("wsNodeId")] 
		public scnNodeId WsNodeId
		{
			get => GetProperty(ref _wsNodeId);
			set => SetProperty(ref _wsNodeId, value);
		}

		[Ordinal(2)] 
		[RED("wsEditorEventId")] 
		public CUInt64 WsEditorEventId
		{
			get => GetProperty(ref _wsEditorEventId);
			set => SetProperty(ref _wsEditorEventId, value);
		}
	}
}
