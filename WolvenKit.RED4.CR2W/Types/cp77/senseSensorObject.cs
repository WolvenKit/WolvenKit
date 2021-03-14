using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSensorObject : ISerializable
	{
		[Ordinal(0)] [RED("presetID")] public TweakDBID PresetID { get; set; }
		[Ordinal(1)] [RED("detectionFactor")] public CFloat DetectionFactor { get; set; }
		[Ordinal(2)] [RED("detectionDropFactor")] public CFloat DetectionDropFactor { get; set; }
		[Ordinal(3)] [RED("detectionCoolDownTime")] public CFloat DetectionCoolDownTime { get; set; }
		[Ordinal(4)] [RED("detectionPartCoolDownTime")] public CFloat DetectionPartCoolDownTime { get; set; }
		[Ordinal(5)] [RED("hearingEnabled")] public CBool HearingEnabled { get; set; }
		[Ordinal(6)] [RED("sensorObjectType")] public CEnum<gamedataSenseObjectType> SensorObjectType { get; set; }

		public senseSensorObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
