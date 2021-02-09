using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HUDInstruction : redEvent
	{
		[Ordinal(0)]  [RED("scannerInstructions")] public CHandle<ScanInstance> ScannerInstructions { get; set; }
		[Ordinal(1)]  [RED("highlightInstructions")] public CHandle<HighlightInstance> HighlightInstructions { get; set; }
		[Ordinal(2)]  [RED("braindanceInstructions")] public CHandle<BraindanceInstance> BraindanceInstructions { get; set; }
		[Ordinal(3)]  [RED("iconsInstruction")] public CHandle<IconsInstance> IconsInstruction { get; set; }
		[Ordinal(4)]  [RED("quickhackInstruction")] public CHandle<QuickhackInstance> QuickhackInstruction { get; set; }

		public HUDInstruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
