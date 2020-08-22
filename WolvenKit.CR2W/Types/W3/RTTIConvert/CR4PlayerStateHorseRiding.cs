using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateHorseRiding : CR4PlayerStateUseGenericVehicle
	{
		[RED("dismountRequest")] 		public CBool DismountRequest { get; set;}

		[RED("vehicleCombatMgr")] 		public CHandle<W3HorseCombatManager> VehicleCombatMgr { get; set;}

		[RED("meleeTicketRequest")] 		public CInt32 MeleeTicketRequest { get; set;}

		[RED("rangeTicketRequest")] 		public CInt32 RangeTicketRequest { get; set;}

		[RED("scabbardsComp")] 		public CHandle<CAnimatedComponent> ScabbardsComp { get; set;}

		[RED("initCamera")] 		public CBool InitCamera { get; set;}

		[RED("currDesiredDist")] 		public CFloat CurrDesiredDist { get; set;}

		[RED("cameraManualRotationDisabled")] 		public CBool CameraManualRotationDisabled { get; set;}

		[RED("wasTrailCameraActive")] 		public CBool WasTrailCameraActive { get; set;}

		[RED("trailCameraTimeStamp")] 		public CFloat TrailCameraTimeStamp { get; set;}

		[RED("trailCameraCooldown")] 		public CFloat TrailCameraCooldown { get; set;}

		[RED("m_shouldEnableAutoRotation")] 		public CBool M_shouldEnableAutoRotation { get; set;}

		public CR4PlayerStateHorseRiding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateHorseRiding(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}