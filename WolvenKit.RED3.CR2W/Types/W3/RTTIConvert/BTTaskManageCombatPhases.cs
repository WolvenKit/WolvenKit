using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageCombatPhases : IBehTreeTask
	{
		[Ordinal(1)] [RED("rangedCombatPhaseParameters")] 		public SCombatPhaseParameters RangedCombatPhaseParameters { get; set;}

		[Ordinal(2)] [RED("closeCombatPhaseParameters")] 		public SCombatPhaseParameters CloseCombatPhaseParameters { get; set;}

		[Ordinal(3)] [RED("nonCombatPhaseParameters")] 		public SCombatPhaseParameters NonCombatPhaseParameters { get; set;}

		[Ordinal(4)] [RED("availableCombatPhasesArray", 2,0)] 		public CArray<SCombatPhaseParameters> AvailableCombatPhasesArray { get; set;}

		[Ordinal(5)] [RED("initialCombatPhasesArray", 2,0)] 		public CArray<SCombatPhaseParameters> InitialCombatPhasesArray { get; set;}

		[Ordinal(6)] [RED("combatPhasesArray", 2,0)] 		public CArray<SCombatPhaseParameters> CombatPhasesArray { get; set;}

		[Ordinal(7)] [RED("setBehVariableName")] 		public CName SetBehVariableName { get; set;}

		[Ordinal(8)] [RED("activationEventReceived")] 		public CFloat ActivationEventReceived { get; set;}

		[Ordinal(9)] [RED("rangedCombatTimeStamp")] 		public CFloat RangedCombatTimeStamp { get; set;}

		[Ordinal(10)] [RED("closeCombatTimeStamp")] 		public CFloat CloseCombatTimeStamp { get; set;}

		[Ordinal(11)] [RED("nonCombatTimeStamp")] 		public CFloat NonCombatTimeStamp { get; set;}

		[Ordinal(12)] [RED("currentCombatPhase")] 		public CInt32 CurrentCombatPhase { get; set;}

		[Ordinal(13)] [RED("afterFirstChoice")] 		public CBool AfterFirstChoice { get; set;}

		public BTTaskManageCombatPhases(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageCombatPhases(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}