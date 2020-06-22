using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBoatComponent : CVehicleComponent
	{
		[RED("sailDir")] 		public CFloat SailDir { get; set;}

		[RED("mountAnimationFinished")] 		public CBool MountAnimationFinished { get; set;}

		[RED("collisionNames", 2,0)] 		public CArray<CName> CollisionNames { get; set;}

		[RED("effects")] 		public ParticleEffectNames Effects { get; set;}

		[RED("boatEntity")] 		public CHandle<W3Boat> BoatEntity { get; set;}

		[RED("passenger")] 		public CHandle<CActor> Passenger { get; set;}

		[RED("sailTilt")] 		public CFloat SailTilt { get; set;}

		[RED("sailAnim")] 		public CHandle<CAnimatedComponent> SailAnim { get; set;}

		[RED("boatAnim")] 		public CHandle<CAnimatedComponent> BoatAnim { get; set;}

		[RED("rudderDir")] 		public CFloat RudderDir { get; set;}

		[RED("isChangingSteer")] 		public CBool IsChangingSteer { get; set;}

		[RED("steerSound")] 		public CBool SteerSound { get; set;}

		[RED("enableCustomMastRotation")] 		public CBool EnableCustomMastRotation { get; set;}

		[RED("IDLE_SPEED_THRESHOLD")] 		public CFloat IDLE_SPEED_THRESHOLD { get; set;}

		[RED("MAST_PARTICLE_THRESHOLD")] 		public CFloat MAST_PARTICLE_THRESHOLD { get; set;}

		[RED("TILT_PARTICLE_THRESHOLD")] 		public CFloat TILT_PARTICLE_THRESHOLD { get; set;}

		[RED("DIVING_PARTICLE_THRESHOLD")] 		public CFloat DIVING_PARTICLE_THRESHOLD { get; set;}

		[RED("WATER_THRESHOLD")] 		public CFloat WATER_THRESHOLD { get; set;}

		[RED("MAST_ROTX_THRESHOLD")] 		public CFloat MAST_ROTX_THRESHOLD { get; set;}

		[RED("MAST_ROT_SAIL_VAL")] 		public CFloat MAST_ROT_SAIL_VAL { get; set;}

		[RED("fr")] 		public Vector Fr { get; set;}

		[RED("ba")] 		public Vector Ba { get; set;}

		[RED("ri")] 		public Vector Ri { get; set;}

		[RED("le")] 		public Vector Le { get; set;}

		[RED("prevTurnFactorX")] 		public CFloat PrevTurnFactorX { get; set;}

		[RED("previousGear")] 		public CInt32 PreviousGear { get; set;}

		[RED("prevMastPosZ")] 		public CFloat PrevMastPosZ { get; set;}

		[RED("prevMastVelZ")] 		public CFloat PrevMastVelZ { get; set;}

		[RED("prevFrontPosZ")] 		public CFloat PrevFrontPosZ { get; set;}

		[RED("prevFrontVelZ")] 		public CFloat PrevFrontVelZ { get; set;}

		[RED("prevRightPosZ")] 		public CFloat PrevRightPosZ { get; set;}

		[RED("prevRightVelZ")] 		public CFloat PrevRightVelZ { get; set;}

		[RED("prevLeftPosZ")] 		public CFloat PrevLeftPosZ { get; set;}

		[RED("prevLeftVelZ")] 		public CFloat PrevLeftVelZ { get; set;}

		[RED("prevBackPosZ")] 		public CFloat PrevBackPosZ { get; set;}

		[RED("prevBackVelZ")] 		public CFloat PrevBackVelZ { get; set;}

		[RED("prevFrontWaterPosZ")] 		public CFloat PrevFrontWaterPosZ { get; set;}

		[RED("sphereSize")] 		public CFloat SphereSize { get; set;}

		[RED("mastSlotTransform")] 		public CMatrix MastSlotTransform { get; set;}

		[RED("frontSlotTransform")] 		public CMatrix FrontSlotTransform { get; set;}

		[RED("backSlotTransform")] 		public CMatrix BackSlotTransform { get; set;}

		[RED("rightSlotTransform")] 		public CMatrix RightSlotTransform { get; set;}

		[RED("leftSlotTransform")] 		public CMatrix LeftSlotTransform { get; set;}

		[RED("wasSailFillSoundPlayed")] 		public CBool WasSailFillSoundPlayed { get; set;}

		[RED("boatMastTrailLoopStarted")] 		public CBool BoatMastTrailLoopStarted { get; set;}

		[RED("dismountStateName")] 		public CName DismountStateName { get; set;}

		[RED("localSpaceCameraTurnPercent")] 		public CFloat LocalSpaceCameraTurnPercent { get; set;}

		public CBoatComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBoatComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}