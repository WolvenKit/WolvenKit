using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDestructionGridCell : CVariable
	{
		[Ordinal(0)] [RED("impactEvent")] public CName ImpactEvent { get; set; }
		[Ordinal(1)] [RED("impactDetailEvent")] public CName ImpactDetailEvent { get; set; }

		public audioVehicleDestructionGridCell(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
