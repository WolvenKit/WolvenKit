using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestFactsDBExCondition : IQuestCondition
	{
		[RED("factId1")] 		public CString FactId1 { get; set;}

		[RED("factId2")] 		public CString FactId2 { get; set;}

		[RED("queryFact")] 		public CEnum<EQueryFact> QueryFact { get; set;}

		[RED("compareFunc")] 		public CEnum<ECompareFunc> CompareFunc { get; set;}

		public CQuestFactsDBExCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestFactsDBExCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}