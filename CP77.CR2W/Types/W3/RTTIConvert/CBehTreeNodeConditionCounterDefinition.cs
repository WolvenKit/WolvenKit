using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeConditionCounterDefinition : CBehTreeNodeConditionDefinition
	{
		[Ordinal(1)] [RED("counterName")] 		public CBehTreeValCName CounterName { get; set;}

		[Ordinal(2)] [RED("counterLowerBound")] 		public CBehTreeValInt CounterLowerBound { get; set;}

		[Ordinal(3)] [RED("counterUpperBound")] 		public CBehTreeValInt CounterUpperBound { get; set;}

		public CBehTreeNodeConditionCounterDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeConditionCounterDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}