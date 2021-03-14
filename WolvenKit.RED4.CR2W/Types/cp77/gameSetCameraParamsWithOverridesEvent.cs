using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetCameraParamsWithOverridesEvent : redEvent
	{
		[Ordinal(0)] [RED("paramsName")] public CName ParamsName { get; set; }
		[Ordinal(1)] [RED("yawMaxLeft")] public CFloat YawMaxLeft { get; set; }
		[Ordinal(2)] [RED("yawMaxRight")] public CFloat YawMaxRight { get; set; }
		[Ordinal(3)] [RED("pitchMax")] public CFloat PitchMax { get; set; }
		[Ordinal(4)] [RED("pitchMin")] public CFloat PitchMin { get; set; }
		[Ordinal(5)] [RED("sensitivityMultX")] public CFloat SensitivityMultX { get; set; }
		[Ordinal(6)] [RED("sensitivityMultY")] public CFloat SensitivityMultY { get; set; }

		public gameSetCameraParamsWithOverridesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
