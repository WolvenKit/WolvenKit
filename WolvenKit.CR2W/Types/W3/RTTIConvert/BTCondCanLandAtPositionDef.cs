using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTCondCanLandAtPositionDef : IBehTreeConditionalTaskDefinition
	{
		[RED("localOffset")] 		public Vector LocalOffset { get; set;}

		[RED("checkLineOfSight")] 		public CBool CheckLineOfSight { get; set;}

		[RED("maxDistanceFromGround")] 		public CBehTreeValFloat MaxDistanceFromGround { get; set;}

		[RED("landOnlyInGuardArea")] 		public CBool LandOnlyInGuardArea { get; set;}

		public BTCondCanLandAtPositionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTCondCanLandAtPositionDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}