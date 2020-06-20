using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateLand : CExplorationStateAbstract
	{
		[RED("m_BehLandRunS")] 		public CName M_BehLandRunS { get; set;}

		[RED("m_LandRunInputAngleF")] 		public CFloat M_LandRunInputAngleF { get; set;}

		[RED("m_BehLandTypeS")] 		public CName M_BehLandTypeS { get; set;}

		[RED("m_BehLandCancelN")] 		public CName M_BehLandCancelN { get; set;}

		[RED("m_BehLandCanEndN")] 		public CName M_BehLandCanEndN { get; set;}

		[RED("m_BehLandSkipToRunN")] 		public CName M_BehLandSkipToRunN { get; set;}

		[RED("m_BehLandSkipToWalkN")] 		public CName M_BehLandSkipToWalkN { get; set;}

		[RED("m_BehLandSkipToIdleN")] 		public CName M_BehLandSkipToIdleN { get; set;}

		[RED("m_BehLandFallForwardN")] 		public CName M_BehLandFallForwardN { get; set;}

		[RED("m_HeightToLandCrouch")] 		public CFloat M_HeightToLandCrouch { get; set;}

		[RED("m_LandDataIdle")] 		public SLandData M_LandDataIdle { get; set;}

		[RED("m_LandDataWalk")] 		public SLandData M_LandDataWalk { get; set;}

		[RED("m_LandDataWalkHigh")] 		public SLandData M_LandDataWalkHigh { get; set;}

		[RED("m_LandDataRun")] 		public SLandData M_LandDataRun { get; set;}

		[RED("m_LandDataSprint")] 		public SLandData M_LandDataSprint { get; set;}

		[RED("m_LandDataHigher")] 		public SLandData M_LandDataHigher { get; set;}

		[RED("m_LandDataAirCollision")] 		public SLandData M_LandDataAirCollision { get; set;}

		[RED("m_LandDataCrouch")] 		public SLandData M_LandDataCrouch { get; set;}

		[RED("m_LandDataFall")] 		public SLandData M_LandDataFall { get; set;}

		[RED("m_LandDataDamage")] 		public SLandData M_LandDataDamage { get; set;}

		[RED("m_LandDataDeath")] 		public SLandData M_LandDataDeath { get; set;}

		[RED("m_LandDataKnockBack")] 		public SLandData M_LandDataKnockBack { get; set;}

		[RED("m_UseBendAddOnLand")] 		public CBool M_UseBendAddOnLand { get; set;}

		[RED("m_AutoRollB")] 		public CBool M_AutoRollB { get; set;}

		[RED("m_AutoSlopeAngleB")] 		public CFloat M_AutoSlopeAngleB { get; set;}

		[RED("m_DamageOverridesRollB")] 		public CBool M_DamageOverridesRollB { get; set;}

		[RED("m_RollMinHeightF")] 		public CFloat M_RollMinHeightF { get; set;}

		[RED("m_RollTimeAfterF")] 		public CFloat M_RollTimeAfterF { get; set;}

		[RED("m_RollMinJumpTotalF")] 		public CFloat M_RollMinJumpTotalF { get; set;}

		[RED("m_AllowHigherJumpB")] 		public CBool M_AllowHigherJumpB { get; set;}

		[RED("m_HighLandingHeightF")] 		public CFloat M_HighLandingHeightF { get; set;}

		[RED("m_AllowSkipB")] 		public CBool M_AllowSkipB { get; set;}

		public CExplorationStateLand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateLand(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}