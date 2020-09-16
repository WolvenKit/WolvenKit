using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTicketAlgorithmMeleeDefinition : ITicketAlgorithmScriptDefinition
	{
		[Ordinal(1)] [RED("priority")] 		public CBehTreeValFloat Priority { get; set;}

		[Ordinal(2)] [RED("activationBonus")] 		public CBehTreeValFloat ActivationBonus { get; set;}

		[Ordinal(3)] [RED("isInVicinityBonus")] 		public CBehTreeValFloat IsInVicinityBonus { get; set;}

		[Ordinal(4)] [RED("vicinityMax")] 		public CBehTreeValFloat VicinityMax { get; set;}

		[Ordinal(5)] [RED("vicinityMin")] 		public CBehTreeValFloat VicinityMin { get; set;}

		[Ordinal(6)] [RED("threatLevelBonus")] 		public CBehTreeValFloat ThreatLevelBonus { get; set;}

		[Ordinal(7)] [RED("moraleBonus")] 		public CBehTreeValFloat MoraleBonus { get; set;}

		[Ordinal(8)] [RED("hpBonus")] 		public CBehTreeValFloat HpBonus { get; set;}

		[Ordinal(9)] [RED("timeBonus")] 		public CBehTreeValFloat TimeBonus { get; set;}

		[Ordinal(10)] [RED("distanceBonus")] 		public CBehTreeValFloat DistanceBonus { get; set;}

		[Ordinal(11)] [RED("desiredDistance")] 		public CBehTreeValFloat DesiredDistance { get; set;}

		[Ordinal(12)] [RED("desiredTime")] 		public CBehTreeValFloat DesiredTime { get; set;}

		[Ordinal(13)] [RED("isAttackedBonus")] 		public CBehTreeValFloat IsAttackedBonus { get; set;}

		[Ordinal(14)] [RED("isAttackedStateDuration")] 		public CBehTreeValFloat IsAttackedStateDuration { get; set;}

		[Ordinal(15)] [RED("inTargetBackBonus")] 		public CBehTreeValFloat InTargetBackBonus { get; set;}

		public CTicketAlgorithmMeleeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTicketAlgorithmMeleeDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}