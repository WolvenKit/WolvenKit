using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationSkatingGlobal : CObject
	{
		[Ordinal(0)] [RED("("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[Ordinal(0)] [RED("("speedLevelCur")] 		public CInt32 SpeedLevelCur { get; set;}

		[Ordinal(0)] [RED("("speedLevelCapDefault")] 		public CInt32 SpeedLevelCapDefault { get; set;}

		[Ordinal(0)] [RED("("speedLevelCap")] 		public CInt32 SpeedLevelCap { get; set;}

		[Ordinal(0)] [RED("("speedLevelTotal")] 		public CInt32 SpeedLevelTotal { get; set;}

		[Ordinal(0)] [RED("("maxSpeedTotal")] 		public CFloat MaxSpeedTotal { get; set;}

		[Ordinal(0)] [RED("("minSpeedTotal")] 		public CFloat MinSpeedTotal { get; set;}

		[Ordinal(0)] [RED("("speedPerLevel")] 		public CFloat SpeedPerLevel { get; set;}

		[Ordinal(0)] [RED("("movementParamsLevels", 2,0)] 		public CArray<SSkatingLevelParams> MovementParamsLevels { get; set;}

		[Ordinal(0)] [RED("("movementLevelsSpeedCurve")] 		public CHandle<CCurve> MovementLevelsSpeedCurve { get; set;}

		[Ordinal(0)] [RED("("movementParams")] 		public SSkatingMovementParams MovementParams { get; set;}

		[Ordinal(0)] [RED("("turnSpeedBase")] 		public CFloat TurnSpeedBase { get; set;}

		[Ordinal(0)] [RED("("dashCooldownTotal")] 		public CFloat DashCooldownTotal { get; set;}

		[Ordinal(0)] [RED("("dashCooldownCur")] 		public CFloat DashCooldownCur { get; set;}

		[Ordinal(0)] [RED("("speedToBrake")] 		public CFloat SpeedToBrake { get; set;}

		[Ordinal(0)] [RED("("speedToStop")] 		public CFloat SpeedToStop { get; set;}

		[Ordinal(0)] [RED("("m_TurnF")] 		public CFloat M_TurnF { get; set;}

		[Ordinal(0)] [RED("("m_Drifting")] 		public CBool M_Drifting { get; set;}

		[Ordinal(0)] [RED("("m_DrifIsLeft")] 		public CBool M_DrifIsLeft { get; set;}

		[Ordinal(0)] [RED("("flowComboCur")] 		public CInt32 FlowComboCur { get; set;}

		[Ordinal(0)] [RED("("flowGapTimeCur")] 		public CFloat FlowGapTimeCur { get; set;}

		[Ordinal(0)] [RED("("flowGapTimeTotal")] 		public CFloat FlowGapTimeTotal { get; set;}

		[Ordinal(0)] [RED("("flowSuccesfullTimeTotal")] 		public CFloat FlowSuccesfullTimeTotal { get; set;}

		[Ordinal(0)] [RED("("flowSuccesfullTime")] 		public CFloat FlowSuccesfullTime { get; set;}

		[Ordinal(0)] [RED("("behParamTurnName")] 		public CName BehParamTurnName { get; set;}

		[Ordinal(0)] [RED("("behParamAccelName")] 		public CName BehParamAccelName { get; set;}

		[Ordinal(0)] [RED("("behParamSpeedName")] 		public CName BehParamSpeedName { get; set;}

		[Ordinal(0)] [RED("("behParamAttackName")] 		public CName BehParamAttackName { get; set;}

		[Ordinal(0)] [RED("("behParamRandAttackName")] 		public CName BehParamRandAttackName { get; set;}

		[Ordinal(0)] [RED("("behParamJumpAttackName")] 		public CName BehParamJumpAttackName { get; set;}

		[Ordinal(0)] [RED("("behParamTurnMax")] 		public CFloat BehParamTurnMax { get; set;}

		[Ordinal(0)] [RED("("behIncreasedSpeed")] 		public CName BehIncreasedSpeed { get; set;}

		[Ordinal(0)] [RED("("behIncreasedFwdSpeed")] 		public CName BehIncreasedFwdSpeed { get; set;}

		[Ordinal(0)] [RED("("active")] 		public CBool Active { get; set;}

		public CExplorationSkatingGlobal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationSkatingGlobal(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}