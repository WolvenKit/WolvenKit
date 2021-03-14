using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class MerchantNPCEmbeddedScenesConditions : CVariable
	{
		[Ordinal(1)] [RED("applyToTag")] 		public CName ApplyToTag { get; set;}

		[Ordinal(2)] [RED("requiredFact")] 		public CString RequiredFact { get; set;}

		[Ordinal(3)] [RED("forbiddenFact")] 		public CString ForbiddenFact { get; set;}

		public MerchantNPCEmbeddedScenesConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new MerchantNPCEmbeddedScenesConditions(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}