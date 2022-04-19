using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneEventSymbol : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("editorEventId")] 
		public CUInt64 EditorEventId
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("originNodeId")] 
		public scnNodeId OriginNodeId
		{
			get => GetPropertyValue<scnNodeId>();
			set => SetPropertyValue<scnNodeId>(value);
		}

		[Ordinal(2)] 
		[RED("sceneEventIds")] 
		public CArray<scnSceneEventId> SceneEventIds
		{
			get => GetPropertyValue<CArray<scnSceneEventId>>();
			set => SetPropertyValue<CArray<scnSceneEventId>>(value);
		}

		public scnSceneEventSymbol()
		{
			EditorEventId = 18446744073709551615;
			OriginNodeId = new() { Id = 4294967295 };
			SceneEventIds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
