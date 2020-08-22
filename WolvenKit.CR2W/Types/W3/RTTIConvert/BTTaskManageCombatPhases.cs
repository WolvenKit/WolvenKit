using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageCombatPhases : IBehTreeTask
	{
		[RED("rangedCombatPhaseParameters")] 		public SCombatPhaseParameters RangedCombatPhaseParameters { get; set;}

		[RED("closeCombatPhaseParameters")] 		public SCombatPhaseParameters CloseCombatPhaseParameters { get; set;}

		[RED("nonCombatPhaseParameters")] 		public SCombatPhaseParameters NonCombatPhaseParameters { get; set;}

		[RED("availableCombatPhasesArray", 2,0)] 		public CArray<SCombatPhaseParameters> AvailableCombatPhasesArray { get; set;}

		[RED("initialCombatPhasesArray", 2,0)] 		public CArray<SCombatPhaseParameters> InitialCombatPhasesArray { get; set;}

		[RED("combatPhasesArray", 2,0)] 		public CArray<SCombatPhaseParameters> CombatPhasesArray { get; set;}

		[RED("setBehVariableName")] 		public CName SetBehVariableName { get; set;}

		[RED("activationEventReceived")] 		public CFloat ActivationEventReceived { get; set;}

		[RED("rangedCombatTimeStamp")] 		public CFloat RangedCombatTimeStamp { get; set;}

		[RED("closeCombatTimeStamp")] 		public CFloat CloseCombatTimeStamp { get; set;}

		[RED("nonCombatTimeStamp")] 		public CFloat NonCombatTimeStamp { get; set;}

		[RED("currentCombatPhase")] 		public CInt32 CurrentCombatPhase { get; set;}

		[RED("afterFirstChoice")] 		public CBool AfterFirstChoice { get; set;}

		public BTTaskManageCombatPhases(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageCombatPhases(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}