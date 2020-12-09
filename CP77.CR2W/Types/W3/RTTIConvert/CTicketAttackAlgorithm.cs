using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTicketAttackAlgorithm : CTicketBaseAlgorithm
	{
		[Ordinal(1)] [RED("invertDistanceImportance")] 		public CBool InvertDistanceImportance { get; set;}

		[Ordinal(2)] [RED("overrideDefaultTicketCount")] 		public CBool OverrideDefaultTicketCount { get; set;}

		[Ordinal(3)] [RED("overridenValueWhenInFront")] 		public CInt32 OverridenValueWhenInFront { get; set;}

		[Ordinal(4)] [RED("overridenValueWhenInBack")] 		public CInt32 OverridenValueWhenInBack { get; set;}

		[Ordinal(5)] [RED("denyTicketWhenNotInFrame")] 		public CBool DenyTicketWhenNotInFrame { get; set;}

		public CTicketAttackAlgorithm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTicketAttackAlgorithm(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}