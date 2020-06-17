using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class MerchantNPCEmbeddedScenesConditions : CVariable
	{
		[RED("applyToTag")] 		public CName ApplyToTag { get; set;}

		[RED("requiredFact")] 		public CString RequiredFact { get; set;}

		[RED("forbiddenFact")] 		public CString ForbiddenFact { get; set;}

		public MerchantNPCEmbeddedScenesConditions(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new MerchantNPCEmbeddedScenesConditions(cr2w);

	}
}