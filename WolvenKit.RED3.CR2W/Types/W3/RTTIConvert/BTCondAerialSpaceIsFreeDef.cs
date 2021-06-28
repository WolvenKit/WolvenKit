using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondAerialSpaceIsFreeDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("localOffset")] 		public Vector LocalOffset { get; set;}

		[Ordinal(2)] [RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[Ordinal(3)] [RED("cylinderRadiusToCheck")] 		public CFloat CylinderRadiusToCheck { get; set;}

		[Ordinal(4)] [RED("cylinderHeightToCheck")] 		public CFloat CylinderHeightToCheck { get; set;}

		[Ordinal(5)] [RED("checkedNode")] 		public CEnum<ETargetName> CheckedNode { get; set;}

		[Ordinal(6)] [RED("namedTarget")] 		public CName NamedTarget { get; set;}

		public BTCondAerialSpaceIsFreeDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}