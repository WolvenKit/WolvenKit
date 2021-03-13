using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskSetEntityAsActionTargetDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("targetTag")] 		public CBehTreeValCName TargetTag { get; set;}

		[Ordinal(2)] [RED("multipleTargetsObjectName")] 		public CName MultipleTargetsObjectName { get; set;}

		[Ordinal(3)] [RED("completeImmediately")] 		public CBool CompleteImmediately { get; set;}

		public BTTaskSetEntityAsActionTargetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskSetEntityAsActionTargetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}