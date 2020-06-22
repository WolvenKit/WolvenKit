using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockForwardLightCustom : CMaterialBlock
	{
		[RED("globalLightDiffuse")] 		public CBool GlobalLightDiffuse { get; set;}

		[RED("globalLightSpecular")] 		public CBool GlobalLightSpecular { get; set;}

		[RED("deferredDiffuse")] 		public CBool DeferredDiffuse { get; set;}

		[RED("deferredSpecular")] 		public CBool DeferredSpecular { get; set;}

		[RED("envProbes")] 		public CBool EnvProbes { get; set;}

		[RED("ambientOcclusion")] 		public CBool AmbientOcclusion { get; set;}

		[RED("fog")] 		public CBool Fog { get; set;}

		[RED("excludeFlags")] 		public CBool ExcludeFlags { get; set;}

		[RED("lightUsageMask")] 		public CEnum<ELightUsageMask> LightUsageMask { get; set;}

		public CMaterialBlockForwardLightCustom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockForwardLightCustom(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}