using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FuseControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("alternativeNameForOFF")] public TweakDBID AlternativeNameForOFF { get; set; }
		[Ordinal(1)]  [RED("alternativeNameForON")] public TweakDBID AlternativeNameForON { get; set; }
		[Ordinal(2)]  [RED("isCLSInitialized")] public CBool IsCLSInitialized { get; set; }
		[Ordinal(3)]  [RED("lightSwitchRandomizerType")] public CEnum<ELightSwitchRandomizerType> LightSwitchRandomizerType { get; set; }
		[Ordinal(4)]  [RED("maxLightsSwitchedAtOnce")] public CInt32 MaxLightsSwitchedAtOnce { get; set; }
		[Ordinal(5)]  [RED("timeTableSetup")] public CHandle<DeviceTimeTableManager> TimeTableSetup { get; set; }
		[Ordinal(6)]  [RED("timeToNextSwitch")] public CFloat TimeToNextSwitch { get; set; }

		public FuseControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
