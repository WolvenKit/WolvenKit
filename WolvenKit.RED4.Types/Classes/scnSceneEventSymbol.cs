using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSceneEventSymbol : RedBaseClass
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

		public scnSceneEventSymbol()
		{
			_editorEventId = 18446744073709551615;
		}
	}
}
