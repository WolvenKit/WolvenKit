using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CGameEnvironmentParams : CVariable
	{
		[Ordinal(1)] [RED("radialBlur")] 		public CEnvRadialBlurParameters RadialBlur { get; set;}

		[Ordinal(2)] [RED("fullscreenBlurIntensity")] 		public CFloat FullscreenBlurIntensity { get; set;}

		[Ordinal(3)] [RED("gameUnderwaterBrightness")] 		public CFloat GameUnderwaterBrightness { get; set;}

		[Ordinal(4)] [RED("dayCycleOverride")] 		public CEnvDayCycleOverrideParameters DayCycleOverride { get; set;}

		[Ordinal(5)] [RED("brightnessTint")] 		public CEnvBrightnessTintParameters BrightnessTint { get; set;}

		[Ordinal(6)] [RED("displaySettings")] 		public CEnvDisplaySettingsParams DisplaySettings { get; set;}

		[Ordinal(7)] [RED("cutsceneDofMode")] 		public CBool CutsceneDofMode { get; set;}

		[Ordinal(8)] [RED("cutsceneOrDialog")] 		public CBool CutsceneOrDialog { get; set;}

		public CGameEnvironmentParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CGameEnvironmentParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}