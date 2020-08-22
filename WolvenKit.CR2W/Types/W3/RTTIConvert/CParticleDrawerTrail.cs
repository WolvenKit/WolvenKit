using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CParticleDrawerTrail : IParticleDrawer
	{
		[RED("texturesPerUnit")] 		public CFloat TexturesPerUnit { get; set;}

		[RED("dynamicTexCoords")] 		public CBool DynamicTexCoords { get; set;}

		[RED("minSegmentsPer360Degrees")] 		public CInt32 MinSegmentsPer360Degrees { get; set;}

		public CParticleDrawerTrail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CParticleDrawerTrail(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}