using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondCanLandAtPosition : IBehTreeTask
	{
		[Ordinal(1)] [RED("localOffset")] 		public Vector LocalOffset { get; set;}

		[Ordinal(2)] [RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[Ordinal(3)] [RED("maxDistanceFromGround")] 		public CFloat MaxDistanceFromGround { get; set;}

		[Ordinal(4)] [RED("landOnlyInGuardArea")] 		public CBool LandOnlyInGuardArea { get; set;}

		[Ordinal(5)] [RED("m_CollisionGroupNames", 2,0)] 		public CArray<CName> M_CollisionGroupNames { get; set;}

		[Ordinal(6)] [RED("m_ObstaclesGroupNames", 2,0)] 		public CArray<CName> M_ObstaclesGroupNames { get; set;}

		public BTCondCanLandAtPosition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondCanLandAtPosition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}