using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerNetworkLevel : ScannerChunk
	{
		[Ordinal(0)] [RED("networkLevel")] public CInt32 NetworkLevel { get; set; }

		public ScannerNetworkLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
