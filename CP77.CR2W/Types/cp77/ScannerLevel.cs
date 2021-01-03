using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScannerLevel : ScannerChunk
	{
		[Ordinal(0)]  [RED("isHard")] public CBool IsHard { get; set; }
		[Ordinal(1)]  [RED("level")] public CInt32 Level { get; set; }

		public ScannerLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
