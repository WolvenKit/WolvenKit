using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGameEnvironmentParams : CVariable
	{
		[Ordinal(0)] [RED("("radialBlur")] 		public CEnvRadialBlurParameters RadialBlur { get; set;}

		[Ordinal(0)] [RED("("fullscreenBlurIntensity")] 		public CFloat FullscreenBlurIntensity { get; set;}

		[Ordinal(0)] [RED("("gameUnderwaterBrightness")] 		public CFloat GameUnderwaterBrightness { get; set;}

		[Ordinal(0)] [RED("("dayCycleOverride")] 		public CEnvDayCycleOverrideParameters DayCycleOverride { get; set;}

		[Ordinal(0)] [RED("("brightnessTint")] 		public CEnvBrightnessTintParameters BrightnessTint { get; set;}

		[Ordinal(0)] [RED("("displaySettings")] 		public CEnvDisplaySettingsParams DisplaySettings { get; set;}

		[Ordinal(0)] [RED("("cutsceneDofMode")] 		public CBool CutsceneDofMode { get; set;}

		[Ordinal(0)] [RED("("cutsceneOrDialog")] 		public CBool CutsceneOrDialog { get; set;}

		public CGameEnvironmentParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGameEnvironmentParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}