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
		[RED("m_ExplorationO")] 		public CHandle<CExplorationStateManager> M_ExplorationO { get; set;}

		[RED("speedLevelCur")] 		public CInt32 SpeedLevelCur { get; set;}

		[RED("speedLevelCapDefault")] 		public CInt32 SpeedLevelCapDefault { get; set;}

		[RED("speedLevelCap")] 		public CInt32 SpeedLevelCap { get; set;}

		[RED("speedLevelTotal")] 		public CInt32 SpeedLevelTotal { get; set;}

		[RED("maxSpeedTotal")] 		public CFloat MaxSpeedTotal { get; set;}

		[RED("minSpeedTotal")] 		public CFloat MinSpeedTotal { get; set;}

		[RED("speedPerLevel")] 		public CFloat SpeedPerLevel { get; set;}

		[RED("movementParamsLevels", 2,0)] 		public CArray<SSkatingLevelParams> MovementParamsLevels { get; set;}

		[RED("movementLevelsSpeedCurve")] 		public CHandle<CCurve> MovementLevelsSpeedCurve { get; set;}

		[RED("movementParams")] 		public SSkatingMovementParams MovementParams { get; set;}

		[RED("turnSpeedBase")] 		public CFloat TurnSpeedBase { get; set;}

		[RED("dashCooldownTotal")] 		public CFloat DashCooldownTotal { get; set;}

		[RED("dashCooldownCur")] 		public CFloat DashCooldownCur { get; set;}

		[RED("speedToBrake")] 		public CFloat SpeedToBrake { get; set;}

		[RED("speedToStop")] 		public CFloat SpeedToStop { get; set;}

		[RED("m_TurnF")] 		public CFloat M_TurnF { get; set;}

		[RED("m_Drifting")] 		public CBool M_Drifting { get; set;}

		[RED("m_DrifIsLeft")] 		public CBool M_DrifIsLeft { get; set;}

		[RED("flowComboCur")] 		public CInt32 FlowComboCur { get; set;}

		[RED("flowGapTimeCur")] 		public CFloat FlowGapTimeCur { get; set;}

		[RED("flowGapTimeTotal")] 		public CFloat FlowGapTimeTotal { get; set;}

		[RED("flowSuccesfullTimeTotal")] 		public CFloat FlowSuccesfullTimeTotal { get; set;}

		[RED("flowSuccesfullTime")] 		public CFloat FlowSuccesfullTime { get; set;}

		[RED("behParamTurnName")] 		public CName BehParamTurnName { get; set;}

		[RED("behParamAccelName")] 		public CName BehParamAccelName { get; set;}

		[RED("behParamSpeedName")] 		public CName BehParamSpeedName { get; set;}

		[RED("behParamAttackName")] 		public CName BehParamAttackName { get; set;}

		[RED("behParamRandAttackName")] 		public CName BehParamRandAttackName { get; set;}

		[RED("behParamJumpAttackName")] 		public CName BehParamJumpAttackName { get; set;}

		[RED("behParamTurnMax")] 		public CFloat BehParamTurnMax { get; set;}

		[RED("behIncreasedSpeed")] 		public CName BehIncreasedSpeed { get; set;}

		[RED("behIncreasedFwdSpeed")] 		public CName BehIncreasedFwdSpeed { get; set;}

		[RED("active")] 		public CBool Active { get; set;}

		public CExplorationSkatingGlobal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationSkatingGlobal(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}