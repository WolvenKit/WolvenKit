using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleDrawerTrail : IParticleDrawer
	{
		[Ordinal(1)] [RED("texturesPerUnit")] 		public CFloat TexturesPerUnit { get; set;}

		[Ordinal(2)] [RED("dynamicTexCoords")] 		public CBool DynamicTexCoords { get; set;}

		[Ordinal(3)] [RED("minSegmentsPer360Degrees")] 		public CInt32 MinSegmentsPer360Degrees { get; set;}

		public CParticleDrawerTrail(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleDrawerTrail(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}