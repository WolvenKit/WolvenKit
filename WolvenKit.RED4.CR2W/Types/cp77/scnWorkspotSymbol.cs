using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnWorkspotSymbol : CVariable
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

		public scnWorkspotSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
