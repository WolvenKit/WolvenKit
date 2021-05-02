using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CTicketAlgorithmMelee : ITicketAlgorithmScript
	{
		[Ordinal(1)] [RED("priority")] 		public CFloat Priority { get; set;}

		[Ordinal(2)] [RED("activationBonus")] 		public CFloat ActivationBonus { get; set;}

		[Ordinal(3)] [RED("threatLevelBonus")] 		public CFloat ThreatLevelBonus { get; set;}

		[Ordinal(4)] [RED("moraleBonus")] 		public CFloat MoraleBonus { get; set;}

		[Ordinal(5)] [RED("hpBonus")] 		public CFloat HpBonus { get; set;}

		[Ordinal(6)] [RED("timeBonus")] 		public CFloat TimeBonus { get; set;}

		[Ordinal(7)] [RED("distanceBonus")] 		public CFloat DistanceBonus { get; set;}

		[Ordinal(8)] [RED("desiredDistance")] 		public CFloat DesiredDistance { get; set;}

		[Ordinal(9)] [RED("desiredTime")] 		public CFloat DesiredTime { get; set;}

		[Ordinal(10)] [RED("isAttackedBonus")] 		public CFloat IsAttackedBonus { get; set;}

		[Ordinal(11)] [RED("isAttackedStateDuration")] 		public CFloat IsAttackedStateDuration { get; set;}

		[Ordinal(12)] [RED("isInVicinityBonus")] 		public CFloat IsInVicinityBonus { get; set;}

		[Ordinal(13)] [RED("vicinityMax")] 		public CFloat VicinityMax { get; set;}

		[Ordinal(14)] [RED("vicinityMin")] 		public CFloat VicinityMin { get; set;}

		[Ordinal(15)] [RED("inTargetBackBonus")] 		public CFloat InTargetBackBonus { get; set;}

		public CTicketAlgorithmMelee(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}