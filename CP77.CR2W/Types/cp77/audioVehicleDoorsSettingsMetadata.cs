using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDoorsSettingsMetadata : CVariable
	{
		[Ordinal(0)]  [RED("door")] public audioVehicleDoorsSettings Door { get; set; }
		[Ordinal(1)]  [RED("hood")] public audioVehicleDoorsSettings Hood { get; set; }
		[Ordinal(2)]  [RED("trunk")] public audioVehicleDoorsSettings Trunk { get; set; }

		public audioVehicleDoorsSettingsMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
