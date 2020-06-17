using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWorldSkyboxParameters : CVariable
	{
		[RED("sunMesh")] 		public CHandle<CMesh> SunMesh { get; set;}

		[RED("sunMaterial")] 		public CHandle<CMaterialInstance> SunMaterial { get; set;}

		[RED("moonMesh")] 		public CHandle<CMesh> MoonMesh { get; set;}

		[RED("moonMaterial")] 		public CHandle<CMaterialInstance> MoonMaterial { get; set;}

		[RED("skyboxMesh")] 		public CHandle<CMesh> SkyboxMesh { get; set;}

		[RED("skyboxMaterial")] 		public CHandle<CMaterialInstance> SkyboxMaterial { get; set;}

		[RED("cloudsMesh")] 		public CHandle<CMesh> CloudsMesh { get; set;}

		[RED("cloudsMaterial")] 		public CHandle<CMaterialInstance> CloudsMaterial { get; set;}

		public SWorldSkyboxParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SWorldSkyboxParameters(cr2w);

	}
}