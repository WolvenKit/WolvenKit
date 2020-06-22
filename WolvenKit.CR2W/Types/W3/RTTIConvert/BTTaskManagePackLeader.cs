using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManagePackLeader : IBehTreeTask
	{
		[RED("packName")] 		public CName PackName { get; set;}

		[RED("leadingRadius")] 		public CFloat LeadingRadius { get; set;}

		[RED("forceMeAsLeader")] 		public CBool ForceMeAsLeader { get; set;}

		[RED("m_checkDelay")] 		public CFloat M_checkDelay { get; set;}

		public BTTaskManagePackLeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManagePackLeader(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}