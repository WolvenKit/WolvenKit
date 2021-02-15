using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FuseControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("timeTableSetup")] public CHandle<DeviceTimeTableManager> TimeTableSetup { get; set; }
		[Ordinal(105)] [RED("maxLightsSwitchedAtOnce")] public CInt32 MaxLightsSwitchedAtOnce { get; set; }
		[Ordinal(106)] [RED("timeToNextSwitch")] public CFloat TimeToNextSwitch { get; set; }
		[Ordinal(107)] [RED("lightSwitchRandomizerType")] public CEnum<ELightSwitchRandomizerType> LightSwitchRandomizerType { get; set; }
		[Ordinal(108)] [RED("alternativeNameForON")] public TweakDBID AlternativeNameForON { get; set; }
		[Ordinal(109)] [RED("alternativeNameForOFF")] public TweakDBID AlternativeNameForOFF { get; set; }
		[Ordinal(110)] [RED("isCLSInitialized")] public CBool IsCLSInitialized { get; set; }

		public FuseControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
