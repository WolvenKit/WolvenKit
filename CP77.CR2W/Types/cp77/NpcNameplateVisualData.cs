using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NpcNameplateVisualData : CVariable
	{
		[Ordinal(0)]  [RED("buffList")] public CArray<gameuiBuffInfo> BuffList { get; set; }
		[Ordinal(1)]  [RED("debuffList")] public CArray<gameuiBuffInfo> DebuffList { get; set; }
		[Ordinal(2)]  [RED("npcNextToCrosshair")] public gameuiNPCNextToTheCrosshair NpcNextToCrosshair { get; set; }

		public NpcNameplateVisualData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
