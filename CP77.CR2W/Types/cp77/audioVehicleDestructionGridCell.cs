using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDestructionGridCell : CVariable
	{
		[Ordinal(0)]  [RED("impactDetailEvent")] public CName ImpactDetailEvent { get; set; }
		[Ordinal(1)]  [RED("impactEvent")] public CName ImpactEvent { get; set; }

		public audioVehicleDestructionGridCell(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
