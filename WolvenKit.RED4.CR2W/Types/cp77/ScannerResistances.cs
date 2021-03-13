using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerResistances : ScannerChunk
	{
		[Ordinal(0)] [RED("resists")] public CArray<ScannerStatDetails> Resists { get; set; }

		public ScannerResistances(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
