using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsManagerPS : gameComponentPS
	{
		[Ordinal(0)] [RED("activeVehicleType")] public CEnum<gamedataVehicleType> ActiveVehicleType { get; set; }

		public QuickSlotsManagerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
