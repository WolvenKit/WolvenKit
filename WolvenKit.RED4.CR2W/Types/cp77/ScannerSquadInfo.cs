using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSquadInfo : ScannerChunk
	{
		[Ordinal(0)] [RED("numberOfSquadMembers")] public CInt32 NumberOfSquadMembers { get; set; }

		public ScannerSquadInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
