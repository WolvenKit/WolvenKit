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
		[Ordinal(1)] [RED("("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[Ordinal(2)] [RED("("speedLevelCur")] 		public CInt32 SpeedLevelCur { get; set;}

		[Ordinal(3)] [RED("("speedLevelCapDefault")] 		public CInt32 SpeedLevelCapDefault { get; set;}

		[Ordinal(4)] [RED("("speedLevelCap")] 		public CInt32 SpeedLevelCap { get; set;}

		[Ordinal(5)] [RED("("speedLevelTotal")] 		public CInt32 SpeedLevelTotal { get; set;}

		[Ordinal(6)] [RED("("maxSpeedTotal")] 		public CFloat MaxSpeedTotal { get; set;}

		[Ordinal(7)] [RED("("minSpeedTotal")] 		public CFloat MinSpeedTotal { get; set;}

		[Ordinal(8)] [RED("("speedPerLevel")] 		public CFloat SpeedPerLevel { get; set;}

		[Ordinal(9)] [RED("("movementParamsLevels", 2,0)] 		public CArray<SSkatingLevelParams> MovementParamsLevels { get; set;}

		[Ordinal(10)] [RED("("movementLevelsSpeedCurve")] 		public CHandle<CCurve> MovementLevelsSpeedCurve { get; set;}

		[Ordinal(11)] [RED("("movementParams")] 		public SSkatingMovementParams MovementParams { get; set;}

		[Ordinal(12)] [RED("("turnSpeedBase")] 		public CFloat TurnSpeedBase { get; set;}

		[Ordinal(13)] [RED("("dashCooldownTotal")] 		public CFloat DashCooldownTotal { get; set;}

		[Ordinal(14)] [RED("("dashCooldownCur")] 		public CFloat DashCooldownCur { get; set;}

		[Ordinal(15)] [RED("("speedToBrake")] 		public CFloat SpeedToBrake { get; set;}

		[Ordinal(16)] [RED("("speedToStop")] 		public CFloat SpeedToStop { get; set;}

		[Ordinal(17)] [RED("("m_TurnF")] 		public CFloat M_TurnF { get; set;}

		[Ordinal(18)] [RED("("m_Drifting")] 		public CBool M_Drifting { get; set;}

		[Ordinal(19)] [RED("("m_DrifIsLeft")] 		public CBool M_DrifIsLeft { get; set;}

		[Ordinal(20)] [RED("("flowComboCur")] 		public CInt32 FlowComboCur { get; set;}

		[Ordinal(21)] [RED("("flowGapTimeCur")] 		public CFloat FlowGapTimeCur { get; set;}

		[Ordinal(22)] [RED("("flowGapTimeTotal")] 		public CFloat FlowGapTimeTotal { get; set;}

		[Ordinal(23)] [RED("("flowSuccesfullTimeTotal")] 		public CFloat FlowSuccesfullTimeTotal { get; set;}

		[Ordinal(24)] [RED("("flowSuccesfullTime")] 		public CFloat FlowSuccesfullTime { get; set;}

		[Ordinal(25)] [RED("("behParamTurnName")] 		public CName BehParamTurnName { get; set;}

		[Ordinal(26)] [RED("("behParamAccelName")] 		public CName BehParamAccelName { get; set;}

		[Ordinal(27)] [RED("("behParamSpeedName")] 		public CName BehParamSpeedName { get; set;}

		[Ordinal(28)] [RED("("behParamAttackName")] 		public CName BehParamAttackName { get; set;}

		[Ordinal(29)] [RED("("behParamRandAttackName")] 		public CName BehParamRandAttackName { get; set;}

		[Ordinal(30)] [RED("("behParamJumpAttackName")] 		public CName BehParamJumpAttackName { get; set;}

		[Ordinal(31)] [RED("("behParamTurnMax")] 		public CFloat BehParamTurnMax { get; set;}

		[Ordinal(32)] [RED("("behIncreasedSpeed")] 		public CName BehIncreasedSpeed { get; set;}

		[Ordinal(33)] [RED("("behIncreasedFwdSpeed")] 		public CName BehIncreasedFwdSpeed { get; set;}

		[Ordinal(34)] [RED("("active")] 		public CBool Active { get; set;}

		public CExplorationSkatingGlobal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationSkatingGlobal(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}