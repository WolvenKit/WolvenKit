using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAIReactionFactTest : CVariable
	{
		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("factId")] 		public CString FactId { get; set;}

		[RED("queryFact")] 		public EQueryFact QueryFact { get; set;}

		[RED("value")] 		public CInt32 Value { get; set;}

		[RED("compareFunc")] 		public ECompareFunc CompareFunc { get; set;}

		public SAIReactionFactTest(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SAIReactionFactTest(cr2w);

	}
}