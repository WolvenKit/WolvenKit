using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTicketAlgorithmMelee : ITicketAlgorithmScript
	{
		[RED("priority")] 		public CFloat Priority { get; set;}

		[RED("activationBonus")] 		public CFloat ActivationBonus { get; set;}

		[RED("threatLevelBonus")] 		public CFloat ThreatLevelBonus { get; set;}

		[RED("moraleBonus")] 		public CFloat MoraleBonus { get; set;}

		[RED("hpBonus")] 		public CFloat HpBonus { get; set;}

		[RED("timeBonus")] 		public CFloat TimeBonus { get; set;}

		[RED("distanceBonus")] 		public CFloat DistanceBonus { get; set;}

		[RED("desiredDistance")] 		public CFloat DesiredDistance { get; set;}

		[RED("desiredTime")] 		public CFloat DesiredTime { get; set;}

		[RED("isAttackedBonus")] 		public CFloat IsAttackedBonus { get; set;}

		[RED("isAttackedStateDuration")] 		public CFloat IsAttackedStateDuration { get; set;}

		[RED("isInVicinityBonus")] 		public CFloat IsInVicinityBonus { get; set;}

		[RED("vicinityMax")] 		public CFloat VicinityMax { get; set;}

		[RED("vicinityMin")] 		public CFloat VicinityMin { get; set;}

		[RED("inTargetBackBonus")] 		public CFloat InTargetBackBonus { get; set;}

		public CTicketAlgorithmMelee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTicketAlgorithmMelee(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}