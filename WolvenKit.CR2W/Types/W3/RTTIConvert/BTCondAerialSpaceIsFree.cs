using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondAerialSpaceIsFree : IBehTreeTask
	{
		[Ordinal(0)] [RED("localOffset")] 		public Vector LocalOffset { get; set;}

		[Ordinal(0)] [RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[Ordinal(0)] [RED("cylinderRadiusToCheck")] 		public CFloat CylinderRadiusToCheck { get; set;}

		[Ordinal(0)] [RED("cylinderHeightToCheck")] 		public CFloat CylinderHeightToCheck { get; set;}

		[Ordinal(0)] [RED("checkedNode")] 		public CEnum<ETargetName> CheckedNode { get; set;}

		[Ordinal(0)] [RED("namedTarget")] 		public CName NamedTarget { get; set;}

		[Ordinal(0)] [RED("m_CollisionGroupNames", 2,0)] 		public CArray<CName> M_CollisionGroupNames { get; set;}

		[Ordinal(0)] [RED("m_LastTestTime")] 		public CFloat M_LastTestTime { get; set;}

		[Ordinal(0)] [RED("m_LastTestResult")] 		public CBool M_LastTestResult { get; set;}

		public BTCondAerialSpaceIsFree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondAerialSpaceIsFree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}