using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnNodeSymbol : CVariable
	{
		private scnNodeId _nodeId;
		private scnNodeId _editorNodeId;
		private CUInt64 _editorEventId;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get
			{
				if (_nodeId == null)
				{
					_nodeId = (scnNodeId) CR2WTypeManager.Create("scnNodeId", "nodeId", cr2w, this);
				}
				return _nodeId;
			}
			set
			{
				if (_nodeId == value)
				{
					return;
				}
				_nodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("editorNodeId")] 
		public scnNodeId EditorNodeId
		{
			get
			{
				if (_editorNodeId == null)
				{
					_editorNodeId = (scnNodeId) CR2WTypeManager.Create("scnNodeId", "editorNodeId", cr2w, this);
				}
				return _editorNodeId;
			}
			set
			{
				if (_editorNodeId == value)
				{
					return;
				}
				_editorNodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public scnNodeSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
