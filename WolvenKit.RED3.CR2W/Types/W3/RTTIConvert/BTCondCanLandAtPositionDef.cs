using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondCanLandAtPositionDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("localOffset")] 		public Vector LocalOffset { get; set;}

		[Ordinal(2)] [RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[Ordinal(3)] [RED("maxDistanceFromGround")] 		public CBehTreeValFloat MaxDistanceFromGround { get; set;}

		[Ordinal(4)] [RED("landOnlyInGuardArea")] 		public CBool LandOnlyInGuardArea { get; set;}

		public BTCondCanLandAtPositionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondCanLandAtPositionDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}