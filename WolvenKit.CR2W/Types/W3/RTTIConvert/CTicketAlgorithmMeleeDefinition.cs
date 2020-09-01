using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTicketAlgorithmMeleeDefinition : ITicketAlgorithmScriptDefinition
	{
		[Ordinal(0)] [RED("priority")] 		public CBehTreeValFloat Priority { get; set;}

		[Ordinal(0)] [RED("activationBonus")] 		public CBehTreeValFloat ActivationBonus { get; set;}

		[Ordinal(0)] [RED("isInVicinityBonus")] 		public CBehTreeValFloat IsInVicinityBonus { get; set;}

		[Ordinal(0)] [RED("vicinityMax")] 		public CBehTreeValFloat VicinityMax { get; set;}

		[Ordinal(0)] [RED("vicinityMin")] 		public CBehTreeValFloat VicinityMin { get; set;}

		[Ordinal(0)] [RED("threatLevelBonus")] 		public CBehTreeValFloat ThreatLevelBonus { get; set;}

		[Ordinal(0)] [RED("moraleBonus")] 		public CBehTreeValFloat MoraleBonus { get; set;}

		[Ordinal(0)] [RED("hpBonus")] 		public CBehTreeValFloat HpBonus { get; set;}

		[Ordinal(0)] [RED("timeBonus")] 		public CBehTreeValFloat TimeBonus { get; set;}

		[Ordinal(0)] [RED("distanceBonus")] 		public CBehTreeValFloat DistanceBonus { get; set;}

		[Ordinal(0)] [RED("desiredDistance")] 		public CBehTreeValFloat DesiredDistance { get; set;}

		[Ordinal(0)] [RED("desiredTime")] 		public CBehTreeValFloat DesiredTime { get; set;}

		[Ordinal(0)] [RED("isAttackedBonus")] 		public CBehTreeValFloat IsAttackedBonus { get; set;}

		[Ordinal(0)] [RED("isAttackedStateDuration")] 		public CBehTreeValFloat IsAttackedStateDuration { get; set;}

		[Ordinal(0)] [RED("inTargetBackBonus")] 		public CBehTreeValFloat InTargetBackBonus { get; set;}

		public CTicketAlgorithmMeleeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTicketAlgorithmMeleeDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}