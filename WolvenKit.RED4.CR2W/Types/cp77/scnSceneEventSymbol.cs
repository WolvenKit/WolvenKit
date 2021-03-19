using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneEventSymbol : CVariable
	{
		private CUInt64 _editorEventId;
		private scnNodeId _originNodeId;
		private CArray<scnSceneEventId> _sceneEventIds;

		[Ordinal(0)] 
		[RED("editorEventId")] 
		public CUInt64 EditorEventId
		{
			get => GetProperty(ref _editorEventId);
			set => SetProperty(ref _editorEventId, value);
		}

		[Ordinal(1)] 
		[RED("originNodeId")] 
		public scnNodeId OriginNodeId
		{
			get => GetProperty(ref _originNodeId);
			set => SetProperty(ref _originNodeId, value);
		}

		[Ordinal(2)] 
		[RED("sceneEventIds")] 
		public CArray<scnSceneEventId> SceneEventIds
		{
			get => GetProperty(ref _sceneEventIds);
			set => SetProperty(ref _sceneEventIds, value);
		}

		public scnSceneEventSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
