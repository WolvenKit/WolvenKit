using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerHealth : ScannerChunk
	{
		[Ordinal(0)] [RED("currentHealth")] public CInt32 CurrentHealth { get; set; }
		[Ordinal(1)] [RED("totalHealth")] public CInt32 TotalHealth { get; set; }

		public ScannerHealth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
