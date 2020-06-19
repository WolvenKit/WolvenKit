using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTicketAlgorithmMeleeDefinition : ITicketAlgorithmScriptDefinition
	{
		[RED("priority")] 		public CBehTreeValFloat Priority { get; set;}

		[RED("activationBonus")] 		public CBehTreeValFloat ActivationBonus { get; set;}

		[RED("isInVicinityBonus")] 		public CBehTreeValFloat IsInVicinityBonus { get; set;}

		[RED("vicinityMax")] 		public CBehTreeValFloat VicinityMax { get; set;}

		[RED("vicinityMin")] 		public CBehTreeValFloat VicinityMin { get; set;}

		[RED("threatLevelBonus")] 		public CBehTreeValFloat ThreatLevelBonus { get; set;}

		[RED("moraleBonus")] 		public CBehTreeValFloat MoraleBonus { get; set;}

		[RED("hpBonus")] 		public CBehTreeValFloat HpBonus { get; set;}

		[RED("timeBonus")] 		public CBehTreeValFloat TimeBonus { get; set;}

		[RED("distanceBonus")] 		public CBehTreeValFloat DistanceBonus { get; set;}

		[RED("desiredDistance")] 		public CBehTreeValFloat DesiredDistance { get; set;}

		[RED("desiredTime")] 		public CBehTreeValFloat DesiredTime { get; set;}

		[RED("isAttackedBonus")] 		public CBehTreeValFloat IsAttackedBonus { get; set;}

		[RED("isAttackedStateDuration")] 		public CBehTreeValFloat IsAttackedStateDuration { get; set;}

		[RED("inTargetBackBonus")] 		public CBehTreeValFloat InTargetBackBonus { get; set;}

		public CTicketAlgorithmMeleeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTicketAlgorithmMeleeDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}