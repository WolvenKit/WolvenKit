using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnWorkspotSymbol : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("wsInstance")] 
		public scnSceneWorkspotInstanceId WsInstance
		{
			get => GetPropertyValue<scnSceneWorkspotInstanceId>();
			set => SetPropertyValue<scnSceneWorkspotInstanceId>(value);
		}

		[Ordinal(1)] 
		[RED("wsNodeId")] 
		public scnNodeId WsNodeId
		{
			get => GetPropertyValue<scnNodeId>();
			set => SetPropertyValue<scnNodeId>(value);
		}

		[Ordinal(2)] 
		[RED("wsEditorEventId")] 
		public CUInt64 WsEditorEventId
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public scnWorkspotSymbol()
		{
			WsInstance = new() { Id = 4294967295 };
			WsNodeId = new() { Id = 4294967295 };
			WsEditorEventId = 18446744073709551615;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
