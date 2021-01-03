using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class toolsLastNodeSelection : CVariable
	{
		[Ordinal(0)]  [RED("editorName")] public CString EditorName { get; set; }
		[Ordinal(1)]  [RED("selectedNodeIDPath")] public toolsEditorObjectIDPath SelectedNodeIDPath { get; set; }

		public toolsLastNodeSelection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
