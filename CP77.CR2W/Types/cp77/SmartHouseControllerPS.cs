using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SmartHouseControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("activePreset")] public CHandle<SmartHousePreset> ActivePreset { get; set; }
		[Ordinal(1)]  [RED("availablePresets")] public CArray<CHandle<SmartHousePreset>> AvailablePresets { get; set; }
		[Ordinal(2)]  [RED("callbackID")] public CUInt32 CallbackID { get; set; }
		[Ordinal(3)]  [RED("smartHouseCustomization")] public SmartHouseConfiguration SmartHouseCustomization { get; set; }
		[Ordinal(4)]  [RED("timetable")] public CArray<SPresetTimetableEntry> Timetable { get; set; }

		public SmartHouseControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
