using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTicketAttackAlgorithmDefinition : CTicketBaseAlgorithmDefinition
	{
		[RED("overrideDefaultTicketCount")] 		public CBehTreeValBool OverrideDefaultTicketCount { get; set;}

		[RED("overridenValueWhenInFront")] 		public CBehTreeValInt OverridenValueWhenInFront { get; set;}

		[RED("overridenValueWhenInBack")] 		public CBehTreeValInt OverridenValueWhenInBack { get; set;}

		[RED("invertDistanceImportance")] 		public CBool InvertDistanceImportance { get; set;}

		[RED("denyTicketWhenNotInFrame")] 		public CBool DenyTicketWhenNotInFrame { get; set;}

		public CTicketAttackAlgorithmDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTicketAttackAlgorithmDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}