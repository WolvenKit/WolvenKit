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
		[Ordinal(0)] [RED("priority")] 		public CFloat Priority { get; set;}

		[Ordinal(0)] [RED("activationBonus")] 		public CFloat ActivationBonus { get; set;}

		[Ordinal(0)] [RED("threatLevelBonus")] 		public CFloat ThreatLevelBonus { get; set;}

		[Ordinal(0)] [RED("moraleBonus")] 		public CFloat MoraleBonus { get; set;}

		[Ordinal(0)] [RED("hpBonus")] 		public CFloat HpBonus { get; set;}

		[Ordinal(0)] [RED("timeBonus")] 		public CFloat TimeBonus { get; set;}

		[Ordinal(0)] [RED("distanceBonus")] 		public CFloat DistanceBonus { get; set;}

		[Ordinal(0)] [RED("desiredDistance")] 		public CFloat DesiredDistance { get; set;}

		[Ordinal(0)] [RED("desiredTime")] 		public CFloat DesiredTime { get; set;}

		[Ordinal(0)] [RED("isAttackedBonus")] 		public CFloat IsAttackedBonus { get; set;}

		[Ordinal(0)] [RED("isAttackedStateDuration")] 		public CFloat IsAttackedStateDuration { get; set;}

		[Ordinal(0)] [RED("isInVicinityBonus")] 		public CFloat IsInVicinityBonus { get; set;}

		[Ordinal(0)] [RED("vicinityMax")] 		public CFloat VicinityMax { get; set;}

		[Ordinal(0)] [RED("vicinityMin")] 		public CFloat VicinityMin { get; set;}

		[Ordinal(0)] [RED("inTargetBackBonus")] 		public CFloat InTargetBackBonus { get; set;}

		public CTicketAlgorithmMelee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTicketAlgorithmMelee(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}