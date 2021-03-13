using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioControllerPS : MediaDeviceControllerPS
	{
		[Ordinal(108)] [RED("radioSetup")] public RadioSetup RadioSetup { get; set; }
		[Ordinal(109)] [RED("stations")] public CArray<RadioStationsMap> Stations { get; set; }
		[Ordinal(110)] [RED("stationsInitialized")] public CBool StationsInitialized { get; set; }

		public RadioControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
