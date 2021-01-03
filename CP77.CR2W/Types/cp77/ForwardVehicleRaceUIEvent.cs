using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ForwardVehicleRaceUIEvent : redEvent
	{
		[Ordinal(0)]  [RED("maxCheckpoints")] public CInt32 MaxCheckpoints { get; set; }
		[Ordinal(1)]  [RED("maxPosition")] public CInt32 MaxPosition { get; set; }
		[Ordinal(2)]  [RED("mode")] public CEnum<vehicleRaceUI> Mode { get; set; }

		public ForwardVehicleRaceUIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
