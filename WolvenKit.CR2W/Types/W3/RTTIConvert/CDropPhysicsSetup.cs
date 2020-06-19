using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDropPhysicsSetup : CObject
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("particles")] 		public CSoft<CParticleSystem> Particles { get; set;}

		[RED("curves", 2,0)] 		public CArray<SDropPhysicsCurves> Curves { get; set;}

		public CDropPhysicsSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDropPhysicsSetup(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}