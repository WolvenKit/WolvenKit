using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleDrawerMesh : IParticleDrawer
	{
		[RED("meshes", 2,0)] 		public CArray<CHandle<CMesh>> Meshes { get; set;}

		[RED("orientationMode")] 		public EMeshParticleOrientationMode OrientationMode { get; set;}

		[RED("lightChannels")] 		public ELightChannel LightChannels { get; set;}

		public CParticleDrawerMesh(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CParticleDrawerMesh(cr2w);

	}
}