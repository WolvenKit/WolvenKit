using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerName : ScannerChunk
	{
		[Ordinal(0)] [RED("displayName")] public CString DisplayName { get; set; }
		[Ordinal(1)] [RED("hasArchetype")] public CBool HasArchetype { get; set; }
		[Ordinal(2)] [RED("textParams")] public CHandle<textTextParameterSet> TextParams { get; set; }

		public ScannerName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
