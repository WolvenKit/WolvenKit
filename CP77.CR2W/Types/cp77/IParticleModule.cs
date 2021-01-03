using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IParticleModule : ISerializable
	{
		[Ordinal(0)]  [RED("editorGroup")] public CString EditorGroup { get; set; }
		[Ordinal(1)]  [RED("editorName")] public CString EditorName { get; set; }
		[Ordinal(2)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public IParticleModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
