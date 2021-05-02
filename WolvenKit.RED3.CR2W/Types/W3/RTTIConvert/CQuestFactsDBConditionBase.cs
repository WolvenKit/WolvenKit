using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestFactsDBConditionBase : IQuestCondition
	{
		[Ordinal(1)] [RED("factId")] 		public CString FactId { get; set;}

		[Ordinal(2)] [RED("queryFact")] 		public CEnum<EQueryFact> QueryFact { get; set;}

		[Ordinal(3)] [RED("value")] 		public CInt32 Value { get; set;}

		[Ordinal(4)] [RED("compareFunc")] 		public CEnum<ECompareFunc> CompareFunc { get; set;}

		public CQuestFactsDBConditionBase(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestFactsDBConditionBase(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}