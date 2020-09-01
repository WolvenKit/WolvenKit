using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWorldSkyboxParameters : CVariable
	{
		[Ordinal(0)] [RED("("sunMesh")] 		public CHandle<CMesh> SunMesh { get; set;}

		[Ordinal(0)] [RED("("sunMaterial")] 		public CHandle<CMaterialInstance> SunMaterial { get; set;}

		[Ordinal(0)] [RED("("moonMesh")] 		public CHandle<CMesh> MoonMesh { get; set;}

		[Ordinal(0)] [RED("("moonMaterial")] 		public CHandle<CMaterialInstance> MoonMaterial { get; set;}

		[Ordinal(0)] [RED("("skyboxMesh")] 		public CHandle<CMesh> SkyboxMesh { get; set;}

		[Ordinal(0)] [RED("("skyboxMaterial")] 		public CHandle<CMaterialInstance> SkyboxMaterial { get; set;}

		[Ordinal(0)] [RED("("cloudsMesh")] 		public CHandle<CMesh> CloudsMesh { get; set;}

		[Ordinal(0)] [RED("("cloudsMaterial")] 		public CHandle<CMaterialInstance> CloudsMaterial { get; set;}

		public SWorldSkyboxParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWorldSkyboxParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}