using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondCanLandAtPosition : IBehTreeTask
	{
		[Ordinal(0)] [RED("localOffset")] 		public Vector LocalOffset { get; set;}

		[Ordinal(0)] [RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[Ordinal(0)] [RED("maxDistanceFromGround")] 		public CFloat MaxDistanceFromGround { get; set;}

		[Ordinal(0)] [RED("landOnlyInGuardArea")] 		public CBool LandOnlyInGuardArea { get; set;}

		[Ordinal(0)] [RED("m_CollisionGroupNames", 2,0)] 		public CArray<CName> M_CollisionGroupNames { get; set;}

		[Ordinal(0)] [RED("m_ObstaclesGroupNames", 2,0)] 		public CArray<CName> M_ObstaclesGroupNames { get; set;}

		public BTCondCanLandAtPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondCanLandAtPosition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}