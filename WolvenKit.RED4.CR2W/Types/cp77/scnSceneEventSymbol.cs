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
			get
			{
				if (_editorEventId == null)
				{
					_editorEventId = (CUInt64) CR2WTypeManager.Create("Uint64", "editorEventId", cr2w, this);
				}
				return _editorEventId;
			}
			set
			{
				if (_editorEventId == value)
				{
					return;
				}
				_editorEventId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("originNodeId")] 
		public scnNodeId OriginNodeId
		{
			get
			{
				if (_originNodeId == null)
				{
					_originNodeId = (scnNodeId) CR2WTypeManager.Create("scnNodeId", "originNodeId", cr2w, this);
				}
				return _originNodeId;
			}
			set
			{
				if (_originNodeId == value)
				{
					return;
				}
				_originNodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sceneEventIds")] 
		public CArray<scnSceneEventId> SceneEventIds
		{
			get
			{
				if (_sceneEventIds == null)
				{
					_sceneEventIds = (CArray<scnSceneEventId>) CR2WTypeManager.Create("array:scnSceneEventId", "sceneEventIds", cr2w, this);
				}
				return _sceneEventIds;
			}
			set
			{
				if (_sceneEventIds == value)
				{
					return;
				}
				_sceneEventIds = value;
				PropertySet(this);
			}
		}

		public scnSceneEventSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
