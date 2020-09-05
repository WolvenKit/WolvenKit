using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSpawnConditionFact : ISpawnCondition
	{
		[Ordinal(1)] [RED("fact")] 		public CString Fact { get; set;}

		[Ordinal(2)] [RED("value")] 		public CInt32 Value { get; set;}

		[Ordinal(3)] [RED("compare")] 		public CEnum<ECompareFunc> Compare { get; set;}

		public CSpawnConditionFact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSpawnConditionFact(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}