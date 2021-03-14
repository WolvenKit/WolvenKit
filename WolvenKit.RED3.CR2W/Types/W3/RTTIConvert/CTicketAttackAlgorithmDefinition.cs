using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTicketAttackAlgorithmDefinition : CTicketBaseAlgorithmDefinition
	{
		[Ordinal(1)] [RED("overrideDefaultTicketCount")] 		public CBehTreeValBool OverrideDefaultTicketCount { get; set;}

		[Ordinal(2)] [RED("overridenValueWhenInFront")] 		public CBehTreeValInt OverridenValueWhenInFront { get; set;}

		[Ordinal(3)] [RED("overridenValueWhenInBack")] 		public CBehTreeValInt OverridenValueWhenInBack { get; set;}

		[Ordinal(4)] [RED("invertDistanceImportance")] 		public CBool InvertDistanceImportance { get; set;}

		[Ordinal(5)] [RED("denyTicketWhenNotInFrame")] 		public CBool DenyTicketWhenNotInFrame { get; set;}

		public CTicketAttackAlgorithmDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTicketAttackAlgorithmDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}