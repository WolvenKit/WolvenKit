using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDoorsSettingsMetadata : CVariable
	{
		[Ordinal(0)] [RED("door")] public audioVehicleDoorsSettings Door { get; set; }
		[Ordinal(1)] [RED("trunk")] public audioVehicleDoorsSettings Trunk { get; set; }
		[Ordinal(2)] [RED("hood")] public audioVehicleDoorsSettings Hood { get; set; }

		public audioVehicleDoorsSettingsMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
