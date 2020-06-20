using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGameEnvironmentParams : CVariable
	{
		[RED("radialBlur")] 		public CEnvRadialBlurParameters RadialBlur { get; set;}

		[RED("fullscreenBlurIntensity")] 		public CFloat FullscreenBlurIntensity { get; set;}

		[RED("gameUnderwaterBrightness")] 		public CFloat GameUnderwaterBrightness { get; set;}

		[RED("dayCycleOverride")] 		public CEnvDayCycleOverrideParameters DayCycleOverride { get; set;}

		[RED("brightnessTint")] 		public CEnvBrightnessTintParameters BrightnessTint { get; set;}

		[RED("displaySettings")] 		public CEnvDisplaySettingsParams DisplaySettings { get; set;}

		[RED("cutsceneDofMode")] 		public CBool CutsceneDofMode { get; set;}

		[RED("cutsceneOrDialog")] 		public CBool CutsceneOrDialog { get; set;}

		public CGameEnvironmentParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGameEnvironmentParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}