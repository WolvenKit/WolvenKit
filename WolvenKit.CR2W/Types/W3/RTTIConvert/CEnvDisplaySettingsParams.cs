using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvDisplaySettingsParams : CVariable
	{
		[RED("enableInstantAdaptation")] 		public CBool EnableInstantAdaptation { get; set;}

		[RED("enableGlobalLightingTrajectory")] 		public CBool EnableGlobalLightingTrajectory { get; set;}

		[RED("enableEnvProbeInstantUpdate")] 		public CBool EnableEnvProbeInstantUpdate { get; set;}

		[RED("allowEnvProbeUpdate")] 		public CBool AllowEnvProbeUpdate { get; set;}

		[RED("allowBloom")] 		public CBool AllowBloom { get; set;}

		[RED("allowColorMod")] 		public CBool AllowColorMod { get; set;}

		[RED("allowAntialiasing")] 		public CBool AllowAntialiasing { get; set;}

		[RED("allowGlobalFog")] 		public CBool AllowGlobalFog { get; set;}

		[RED("allowDOF")] 		public CBool AllowDOF { get; set;}

		[RED("allowSSAO")] 		public CBool AllowSSAO { get; set;}

		[RED("allowCloudsShadow")] 		public CBool AllowCloudsShadow { get; set;}

		[RED("allowVignette")] 		public CBool AllowVignette { get; set;}

		[RED("allowWaterShader")] 		public CBool AllowWaterShader { get; set;}

		[RED("gamma")] 		public CFloat Gamma { get; set;}

		public CEnvDisplaySettingsParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvDisplaySettingsParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}