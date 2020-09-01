using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTicketBaseAlgorithm : ITicketAlgorithmScript
	{
		[Ordinal(0)] [RED("resetImportanceOnSpecialCombatAction")] 		public CBool ResetImportanceOnSpecialCombatAction { get; set;}

		[Ordinal(0)] [RED("threatLevelBonus")] 		public CFloat ThreatLevelBonus { get; set;}

		[Ordinal(0)] [RED("activationBonus")] 		public CFloat ActivationBonus { get; set;}

		public CTicketBaseAlgorithm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTicketBaseAlgorithm(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}