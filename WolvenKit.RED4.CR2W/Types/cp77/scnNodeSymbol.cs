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
			get => GetProperty(ref _nodeId);
			set => SetProperty(ref _nodeId, value);
		}

		[Ordinal(1)] 
		[RED("editorNodeId")] 
		public scnNodeId EditorNodeId
		{
			get => GetProperty(ref _editorNodeId);
			set => SetProperty(ref _editorNodeId, value);
		}

		[Ordinal(2)] 
		[RED("editorEventId")] 
		public CUInt64 EditorEventId
		{
			get => GetProperty(ref _editorEventId);
			set => SetProperty(ref _editorEventId, value);
		}

		public scnNodeSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
