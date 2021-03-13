using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateHorseRiding : CR4PlayerStateUseGenericVehicle
	{
		[Ordinal(1)] [RED("dismountRequest")] 		public CBool DismountRequest { get; set;}

		[Ordinal(2)] [RED("vehicleCombatMgr")] 		public CHandle<W3HorseCombatManager> VehicleCombatMgr { get; set;}

		[Ordinal(3)] [RED("meleeTicketRequest")] 		public CInt32 MeleeTicketRequest { get; set;}

		[Ordinal(4)] [RED("rangeTicketRequest")] 		public CInt32 RangeTicketRequest { get; set;}

		[Ordinal(5)] [RED("scabbardsComp")] 		public CHandle<CAnimatedComponent> ScabbardsComp { get; set;}

		[Ordinal(6)] [RED("initCamera")] 		public CBool InitCamera { get; set;}

		[Ordinal(7)] [RED("currDesiredDist")] 		public CFloat CurrDesiredDist { get; set;}

		[Ordinal(8)] [RED("cameraManualRotationDisabled")] 		public CBool CameraManualRotationDisabled { get; set;}

		[Ordinal(9)] [RED("wasTrailCameraActive")] 		public CBool WasTrailCameraActive { get; set;}

		[Ordinal(10)] [RED("trailCameraTimeStamp")] 		public CFloat TrailCameraTimeStamp { get; set;}

		[Ordinal(11)] [RED("trailCameraCooldown")] 		public CFloat TrailCameraCooldown { get; set;}

		[Ordinal(12)] [RED("m_shouldEnableAutoRotation")] 		public CBool M_shouldEnableAutoRotation { get; set;}

		public CR4PlayerStateHorseRiding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateHorseRiding(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}