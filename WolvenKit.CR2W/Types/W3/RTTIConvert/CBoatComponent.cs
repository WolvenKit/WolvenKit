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
		[Ordinal(0)] [RED("sailDir")] 		public CFloat SailDir { get; set;}

		[Ordinal(0)] [RED("mountAnimationFinished")] 		public CBool MountAnimationFinished { get; set;}

		[Ordinal(0)] [RED("collisionNames", 2,0)] 		public CArray<CName> CollisionNames { get; set;}

		[Ordinal(0)] [RED("effects")] 		public ParticleEffectNames Effects { get; set;}

		[Ordinal(0)] [RED("boatEntity")] 		public CHandle<W3Boat> BoatEntity { get; set;}

		[Ordinal(0)] [RED("passenger")] 		public CHandle<CActor> Passenger { get; set;}

		[Ordinal(0)] [RED("sailTilt")] 		public CFloat SailTilt { get; set;}

		[Ordinal(0)] [RED("sailAnim")] 		public CHandle<CAnimatedComponent> SailAnim { get; set;}

		[Ordinal(0)] [RED("boatAnim")] 		public CHandle<CAnimatedComponent> BoatAnim { get; set;}

		[Ordinal(0)] [RED("rudderDir")] 		public CFloat RudderDir { get; set;}

		[Ordinal(0)] [RED("isChangingSteer")] 		public CBool IsChangingSteer { get; set;}

		[Ordinal(0)] [RED("steerSound")] 		public CBool SteerSound { get; set;}

		[Ordinal(0)] [RED("enableCustomMastRotation")] 		public CBool EnableCustomMastRotation { get; set;}

		[Ordinal(0)] [RED("IDLE_SPEED_THRESHOLD")] 		public CFloat IDLE_SPEED_THRESHOLD { get; set;}

		[Ordinal(0)] [RED("MAST_PARTICLE_THRESHOLD")] 		public CFloat MAST_PARTICLE_THRESHOLD { get; set;}

		[Ordinal(0)] [RED("TILT_PARTICLE_THRESHOLD")] 		public CFloat TILT_PARTICLE_THRESHOLD { get; set;}

		[Ordinal(0)] [RED("DIVING_PARTICLE_THRESHOLD")] 		public CFloat DIVING_PARTICLE_THRESHOLD { get; set;}

		[Ordinal(0)] [RED("WATER_THRESHOLD")] 		public CFloat WATER_THRESHOLD { get; set;}

		[Ordinal(0)] [RED("MAST_ROTX_THRESHOLD")] 		public CFloat MAST_ROTX_THRESHOLD { get; set;}

		[Ordinal(0)] [RED("MAST_ROT_SAIL_VAL")] 		public CFloat MAST_ROT_SAIL_VAL { get; set;}

		[Ordinal(0)] [RED("fr")] 		public Vector Fr { get; set;}

		[Ordinal(0)] [RED("ba")] 		public Vector Ba { get; set;}

		[Ordinal(0)] [RED("ri")] 		public Vector Ri { get; set;}

		[Ordinal(0)] [RED("le")] 		public Vector Le { get; set;}

		[Ordinal(0)] [RED("prevTurnFactorX")] 		public CFloat PrevTurnFactorX { get; set;}

		[Ordinal(0)] [RED("previousGear")] 		public CInt32 PreviousGear { get; set;}

		[Ordinal(0)] [RED("prevMastPosZ")] 		public CFloat PrevMastPosZ { get; set;}

		[Ordinal(0)] [RED("prevMastVelZ")] 		public CFloat PrevMastVelZ { get; set;}

		[Ordinal(0)] [RED("prevFrontPosZ")] 		public CFloat PrevFrontPosZ { get; set;}

		[Ordinal(0)] [RED("prevFrontVelZ")] 		public CFloat PrevFrontVelZ { get; set;}

		[Ordinal(0)] [RED("prevRightPosZ")] 		public CFloat PrevRightPosZ { get; set;}

		[Ordinal(0)] [RED("prevRightVelZ")] 		public CFloat PrevRightVelZ { get; set;}

		[Ordinal(0)] [RED("prevLeftPosZ")] 		public CFloat PrevLeftPosZ { get; set;}

		[Ordinal(0)] [RED("prevLeftVelZ")] 		public CFloat PrevLeftVelZ { get; set;}

		[Ordinal(0)] [RED("prevBackPosZ")] 		public CFloat PrevBackPosZ { get; set;}

		[Ordinal(0)] [RED("prevBackVelZ")] 		public CFloat PrevBackVelZ { get; set;}

		[Ordinal(0)] [RED("prevFrontWaterPosZ")] 		public CFloat PrevFrontWaterPosZ { get; set;}

		[Ordinal(0)] [RED("sphereSize")] 		public CFloat SphereSize { get; set;}

		[Ordinal(0)] [RED("mastSlotTransform")] 		public CMatrix MastSlotTransform { get; set;}

		[Ordinal(0)] [RED("frontSlotTransform")] 		public CMatrix FrontSlotTransform { get; set;}

		[Ordinal(0)] [RED("backSlotTransform")] 		public CMatrix BackSlotTransform { get; set;}

		[Ordinal(0)] [RED("rightSlotTransform")] 		public CMatrix RightSlotTransform { get; set;}

		[Ordinal(0)] [RED("leftSlotTransform")] 		public CMatrix LeftSlotTransform { get; set;}

		[Ordinal(0)] [RED("wasSailFillSoundPlayed")] 		public CBool WasSailFillSoundPlayed { get; set;}

		[Ordinal(0)] [RED("boatMastTrailLoopStarted")] 		public CBool BoatMastTrailLoopStarted { get; set;}

		[Ordinal(0)] [RED("dismountStateName")] 		public CName DismountStateName { get; set;}

		[Ordinal(0)] [RED("localSpaceCameraTurnPercent")] 		public CFloat LocalSpaceCameraTurnPercent { get; set;}

		public CBoatComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBoatComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}