using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStorySceneCameraLightMod : CVariable
	{
		[Ordinal(0)] [RED("("deactivateLight")] 		public CBool DeactivateLight { get; set;}

		[Ordinal(0)] [RED("("useCustomLight")] 		public CBool UseCustomLight { get; set;}

		[Ordinal(0)] [RED("("overrideColor")] 		public SSimpleCurve OverrideColor { get; set;}

		[Ordinal(0)] [RED("("lightOffset")] 		public Vector LightOffset { get; set;}

		[Ordinal(0)] [RED("("brightnessScale")] 		public CFloat BrightnessScale { get; set;}

		[Ordinal(0)] [RED("("radiusScale")] 		public CFloat RadiusScale { get; set;}

		[Ordinal(0)] [RED("("useCustomAttenuation")] 		public CBool UseCustomAttenuation { get; set;}

		[Ordinal(0)] [RED("("attenuation")] 		public CFloat Attenuation { get; set;}

		[Ordinal(0)] [RED("("usageMask")] 		public CEnum<ECameraLightBitfield> UsageMask { get; set;}

		public SStorySceneCameraLightMod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStorySceneCameraLightMod(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}