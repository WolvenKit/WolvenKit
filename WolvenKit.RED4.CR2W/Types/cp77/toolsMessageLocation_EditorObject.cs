using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsMessageLocation_EditorObject : toolsIMessageLocation
	{
		[Ordinal(0)] [RED("path")] public toolsEditorObjectIDPath Path { get; set; }

		public toolsMessageLocation_EditorObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
