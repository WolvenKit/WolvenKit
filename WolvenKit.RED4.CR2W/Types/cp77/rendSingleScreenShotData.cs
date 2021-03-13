using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendSingleScreenShotData : ISerializable
	{
		[Ordinal(0)] [RED("mode")] public CEnum<rendScreenshotMode> Mode { get; set; }
		[Ordinal(1)] [RED("outputPath")] public AbsolutePathSerializable OutputPath { get; set; }
		[Ordinal(2)] [RED("resolution")] public CEnum<renddimEPreset> Resolution { get; set; }
		[Ordinal(3)] [RED("resolutionMultiplier")] public CEnum<rendResolutionMultiplier> ResolutionMultiplier { get; set; }
		[Ordinal(4)] [RED("emmModes")] public CArray<CEnum<EEnvManagerModifier>> EmmModes { get; set; }
		[Ordinal(5)] [RED("forceLOD0")] public CBool ForceLOD0 { get; set; }
		[Ordinal(6)] [RED("saveFormat")] public CEnum<ESaveFormat> SaveFormat { get; set; }

		public rendSingleScreenShotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
