using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockForwardLightCustom : CMaterialBlock
	{
		[Ordinal(1)] [RED("globalLightDiffuse")] 		public CBool GlobalLightDiffuse { get; set;}

		[Ordinal(2)] [RED("globalLightSpecular")] 		public CBool GlobalLightSpecular { get; set;}

		[Ordinal(3)] [RED("deferredDiffuse")] 		public CBool DeferredDiffuse { get; set;}

		[Ordinal(4)] [RED("deferredSpecular")] 		public CBool DeferredSpecular { get; set;}

		[Ordinal(5)] [RED("envProbes")] 		public CBool EnvProbes { get; set;}

		[Ordinal(6)] [RED("ambientOcclusion")] 		public CBool AmbientOcclusion { get; set;}

		[Ordinal(7)] [RED("fog")] 		public CBool Fog { get; set;}

		[Ordinal(8)] [RED("excludeFlags")] 		public CBool ExcludeFlags { get; set;}

		[Ordinal(9)] [RED("lightUsageMask")] 		public CEnum<ELightUsageMask> LightUsageMask { get; set;}

		public CMaterialBlockForwardLightCustom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockForwardLightCustom(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}