using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FactCondition : ISpawnScriptCondition
	{
		[Ordinal(1)] [RED("("fact")] 		public CString Fact { get; set;}

		[Ordinal(2)] [RED("("factValue")] 		public CInt32 FactValue { get; set;}

		[Ordinal(3)] [RED("("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[Ordinal(4)] [RED("("queryFactVal")] 		public CInt32 QueryFactVal { get; set;}

		public W3FactCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3FactCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}