using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DisassemblableComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("disassembled")] public CBool Disassembled { get; set; }
		[Ordinal(1)]  [RED("disassembleTargetRequesters")] public CArray<wCHandle<gameObject>> DisassembleTargetRequesters { get; set; }

		public DisassemblableComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
