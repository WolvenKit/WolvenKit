using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IBehTreeAtomicBinaryCondition : IBehTreeAtomicCondition
	{
		[Ordinal(1)] [RED("condition1")] 		public CPtr<IBehTreeAtomicCondition> Condition1 { get; set;}

		[Ordinal(2)] [RED("condition2")] 		public CPtr<IBehTreeAtomicCondition> Condition2 { get; set;}

		public IBehTreeAtomicBinaryCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IBehTreeAtomicBinaryCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}