using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateLand : CExplorationStateAbstract
	{
		[Ordinal(1)] [RED("m_BehLandRunS")] 		public CName M_BehLandRunS { get; set;}

		[Ordinal(2)] [RED("m_LandRunInputAngleF")] 		public CFloat M_LandRunInputAngleF { get; set;}

		[Ordinal(3)] [RED("m_BehLandTypeS")] 		public CName M_BehLandTypeS { get; set;}

		[Ordinal(4)] [RED("m_BehLandCancelN")] 		public CName M_BehLandCancelN { get; set;}

		[Ordinal(5)] [RED("m_BehLandCanEndN")] 		public CName M_BehLandCanEndN { get; set;}

		[Ordinal(6)] [RED("m_BehLandSkipToRunN")] 		public CName M_BehLandSkipToRunN { get; set;}

		[Ordinal(7)] [RED("m_BehLandSkipToWalkN")] 		public CName M_BehLandSkipToWalkN { get; set;}

		[Ordinal(8)] [RED("m_BehLandSkipToIdleN")] 		public CName M_BehLandSkipToIdleN { get; set;}

		[Ordinal(9)] [RED("m_BehLandFallForwardN")] 		public CName M_BehLandFallForwardN { get; set;}

		[Ordinal(10)] [RED("m_HeightToLandCrouch")] 		public CFloat M_HeightToLandCrouch { get; set;}

		[Ordinal(11)] [RED("m_LandTypeE")] 		public CEnum<ELandType> M_LandTypeE { get; set;}

		[Ordinal(12)] [RED("m_LandDataIdle")] 		public SLandData M_LandDataIdle { get; set;}

		[Ordinal(13)] [RED("m_LandDataWalk")] 		public SLandData M_LandDataWalk { get; set;}

		[Ordinal(14)] [RED("m_LandDataWalkHigh")] 		public SLandData M_LandDataWalkHigh { get; set;}

		[Ordinal(15)] [RED("m_LandDataRun")] 		public SLandData M_LandDataRun { get; set;}

		[Ordinal(16)] [RED("m_LandDataSprint")] 		public SLandData M_LandDataSprint { get; set;}

		[Ordinal(17)] [RED("m_LandDataHigher")] 		public SLandData M_LandDataHigher { get; set;}

		[Ordinal(18)] [RED("m_LandDataAirCollision")] 		public SLandData M_LandDataAirCollision { get; set;}

		[Ordinal(19)] [RED("m_LandDataCrouch")] 		public SLandData M_LandDataCrouch { get; set;}

		[Ordinal(20)] [RED("m_LandDataFall")] 		public SLandData M_LandDataFall { get; set;}

		[Ordinal(21)] [RED("m_LandDataDamage")] 		public SLandData M_LandDataDamage { get; set;}

		[Ordinal(22)] [RED("m_LandDataDeath")] 		public SLandData M_LandDataDeath { get; set;}

		[Ordinal(23)] [RED("m_LandDataKnockBack")] 		public SLandData M_LandDataKnockBack { get; set;}

		[Ordinal(24)] [RED("m_LandData")] 		public SLandData M_LandData { get; set;}

		[Ordinal(25)] [RED("m_UseBendAddOnLand")] 		public CBool M_UseBendAddOnLand { get; set;}

		[Ordinal(26)] [RED("m_AutoRollB")] 		public CBool M_AutoRollB { get; set;}

		[Ordinal(27)] [RED("m_AutoSlopeAngleB")] 		public CFloat M_AutoSlopeAngleB { get; set;}

		[Ordinal(28)] [RED("m_AutoRollSlopeCoefF")] 		public CFloat M_AutoRollSlopeCoefF { get; set;}

		[Ordinal(29)] [RED("m_DamageOverridesRollB")] 		public CBool M_DamageOverridesRollB { get; set;}

		[Ordinal(30)] [RED("m_RollingB")] 		public CBool M_RollingB { get; set;}

		[Ordinal(31)] [RED("m_RollIsSlopeB")] 		public CBool M_RollIsSlopeB { get; set;}

		[Ordinal(32)] [RED("m_RollMinHeightF")] 		public CFloat M_RollMinHeightF { get; set;}

		[Ordinal(33)] [RED("m_RollTimeAfterF")] 		public CFloat M_RollTimeAfterF { get; set;}

		[Ordinal(34)] [RED("m_RollMinJumpTotalF")] 		public CFloat M_RollMinJumpTotalF { get; set;}

		[Ordinal(35)] [RED("m_SlidingB")] 		public CBool M_SlidingB { get; set;}

		[Ordinal(36)] [RED("m_SlideCheckedSecondFrameB")] 		public CBool M_SlideCheckedSecondFrameB { get; set;}

		[Ordinal(37)] [RED("m_SlideSavingVelocityV")] 		public Vector M_SlideSavingVelocityV { get; set;}

		[Ordinal(38)] [RED("m_AllowHigherJumpB")] 		public CBool M_AllowHigherJumpB { get; set;}

		[Ordinal(39)] [RED("m_HighLandingHeightF")] 		public CFloat M_HighLandingHeightF { get; set;}

		[Ordinal(40)] [RED("m_AllowSkipB")] 		public CBool M_AllowSkipB { get; set;}

		[Ordinal(41)] [RED("m_RunCoefF")] 		public CFloat M_RunCoefF { get; set;}

		[Ordinal(42)] [RED("m_FallIsForwardB")] 		public CBool M_FallIsForwardB { get; set;}

		[Ordinal(43)] [RED("m_ToFallB")] 		public CBool M_ToFallB { get; set;}

		[Ordinal(44)] [RED("m_ReadyToEndB")] 		public CBool M_ReadyToEndB { get; set;}

		public CExplorationStateLand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateLand(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}