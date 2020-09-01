using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondAerialSpaceIsFreeDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(0)] [RED("localOffset")] 		public Vector LocalOffset { get; set;}

		[Ordinal(0)] [RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[Ordinal(0)] [RED("cylinderRadiusToCheck")] 		public CFloat CylinderRadiusToCheck { get; set;}

		[Ordinal(0)] [RED("cylinderHeightToCheck")] 		public CFloat CylinderHeightToCheck { get; set;}

		[Ordinal(0)] [RED("checkedNode")] 		public CEnum<ETargetName> CheckedNode { get; set;}

		[Ordinal(0)] [RED("namedTarget")] 		public CName NamedTarget { get; set;}

		public BTCondAerialSpaceIsFreeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondAerialSpaceIsFreeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}