using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleDrawerMesh : IParticleDrawer
	{
		[Ordinal(1)] [RED("meshes", 2,0)] 		public CArray<CHandle<CMesh>> Meshes { get; set;}

		[Ordinal(2)] [RED("orientationMode")] 		public CEnum<EMeshParticleOrientationMode> OrientationMode { get; set;}

		[Ordinal(3)] [RED("lightChannels")] 		public CEnum<ELightChannel> LightChannels { get; set;}

		public CParticleDrawerMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleDrawerMesh(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}