using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IParticleModule : ISerializable
	{
		[Ordinal(0)] [RED("editorName")] public CString EditorName { get; set; }
		[Ordinal(1)] [RED("editorGroup")] public CString EditorGroup { get; set; }
		[Ordinal(2)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public IParticleModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
