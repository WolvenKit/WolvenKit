using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceBraindanceCameraToggle : redEvent
	{
		[Ordinal(0)] [RED("editorState")] public CBool EditorState { get; set; }

		public ForceBraindanceCameraToggle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
