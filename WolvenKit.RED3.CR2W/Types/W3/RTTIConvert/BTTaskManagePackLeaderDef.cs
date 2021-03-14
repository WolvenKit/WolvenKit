using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManagePackLeaderDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("packName")] 		public CBehTreeValCName PackName { get; set;}

		[Ordinal(2)] [RED("leadingRadius")] 		public CFloat LeadingRadius { get; set;}

		[Ordinal(3)] [RED("forceMeAsLeader")] 		public CBool ForceMeAsLeader { get; set;}

		public BTTaskManagePackLeaderDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManagePackLeaderDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}