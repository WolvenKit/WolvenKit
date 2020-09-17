using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBoatComponent : CVehicleComponent
	{
		[Ordinal(1)] [RED("sailDir")] 		public CFloat SailDir { get; set;}

		[Ordinal(2)] [RED("mountAnimationFinished")] 		public CBool MountAnimationFinished { get; set;}

		[Ordinal(3)] [RED("collisionNames", 2,0)] 		public CArray<CName> CollisionNames { get; set;}

		[Ordinal(4)] [RED("effects")] 		public ParticleEffectNames Effects { get; set;}

		[Ordinal(5)] [RED("boatEntity")] 		public CHandle<W3Boat> BoatEntity { get; set;}

		[Ordinal(6)] [RED("passenger")] 		public CHandle<CActor> Passenger { get; set;}

		[Ordinal(7)] [RED("sailTilt")] 		public CFloat SailTilt { get; set;}

		[Ordinal(8)] [RED("sailAnim")] 		public CHandle<CAnimatedComponent> SailAnim { get; set;}

		[Ordinal(9)] [RED("boatAnim")] 		public CHandle<CAnimatedComponent> BoatAnim { get; set;}

		[Ordinal(10)] [RED("rudderDir")] 		public CFloat RudderDir { get; set;}

		[Ordinal(11)] [RED("isChangingSteer")] 		public CBool IsChangingSteer { get; set;}

		[Ordinal(12)] [RED("steerSound")] 		public CBool SteerSound { get; set;}

		[Ordinal(13)] [RED("enableCustomMastRotation")] 		public CBool EnableCustomMastRotation { get; set;}

		[Ordinal(14)] [RED("IDLE_SPEED_THRESHOLD")] 		public CFloat IDLE_SPEED_THRESHOLD { get; set;}

		[Ordinal(15)] [RED("MAST_PARTICLE_THRESHOLD")] 		public CFloat MAST_PARTICLE_THRESHOLD { get; set;}

		[Ordinal(16)] [RED("TILT_PARTICLE_THRESHOLD")] 		public CFloat TILT_PARTICLE_THRESHOLD { get; set;}

		[Ordinal(17)] [RED("DIVING_PARTICLE_THRESHOLD")] 		public CFloat DIVING_PARTICLE_THRESHOLD { get; set;}

		[Ordinal(18)] [RED("WATER_THRESHOLD")] 		public CFloat WATER_THRESHOLD { get; set;}

		[Ordinal(19)] [RED("MAST_ROTX_THRESHOLD")] 		public CFloat MAST_ROTX_THRESHOLD { get; set;}

		[Ordinal(20)] [RED("MAST_ROT_SAIL_VAL")] 		public CFloat MAST_ROT_SAIL_VAL { get; set;}

		[Ordinal(21)] [RED("fr")] 		public Vector Fr { get; set;}

		[Ordinal(22)] [RED("ba")] 		public Vector Ba { get; set;}

		[Ordinal(23)] [RED("ri")] 		public Vector Ri { get; set;}

		[Ordinal(24)] [RED("le")] 		public Vector Le { get; set;}

		[Ordinal(25)] [RED("prevTurnFactorX")] 		public CFloat PrevTurnFactorX { get; set;}

		[Ordinal(26)] [RED("previousGear")] 		public CInt32 PreviousGear { get; set;}

		[Ordinal(27)] [RED("prevMastPosZ")] 		public CFloat PrevMastPosZ { get; set;}

		[Ordinal(28)] [RED("prevMastVelZ")] 		public CFloat PrevMastVelZ { get; set;}

		[Ordinal(29)] [RED("prevFrontPosZ")] 		public CFloat PrevFrontPosZ { get; set;}

		[Ordinal(30)] [RED("prevFrontVelZ")] 		public CFloat PrevFrontVelZ { get; set;}

		[Ordinal(31)] [RED("prevRightPosZ")] 		public CFloat PrevRightPosZ { get; set;}

		[Ordinal(32)] [RED("prevRightVelZ")] 		public CFloat PrevRightVelZ { get; set;}

		[Ordinal(33)] [RED("prevLeftPosZ")] 		public CFloat PrevLeftPosZ { get; set;}

		[Ordinal(34)] [RED("prevLeftVelZ")] 		public CFloat PrevLeftVelZ { get; set;}

		[Ordinal(35)] [RED("prevBackPosZ")] 		public CFloat PrevBackPosZ { get; set;}

		[Ordinal(36)] [RED("prevBackVelZ")] 		public CFloat PrevBackVelZ { get; set;}

		[Ordinal(37)] [RED("prevFrontWaterPosZ")] 		public CFloat PrevFrontWaterPosZ { get; set;}

		[Ordinal(38)] [RED("sphereSize")] 		public CFloat SphereSize { get; set;}

		[Ordinal(39)] [RED("mastSlotTransform")] 		public CMatrix MastSlotTransform { get; set;}

		[Ordinal(40)] [RED("frontSlotTransform")] 		public CMatrix FrontSlotTransform { get; set;}

		[Ordinal(41)] [RED("backSlotTransform")] 		public CMatrix BackSlotTransform { get; set;}

		[Ordinal(42)] [RED("rightSlotTransform")] 		public CMatrix RightSlotTransform { get; set;}

		[Ordinal(43)] [RED("leftSlotTransform")] 		public CMatrix LeftSlotTransform { get; set;}

		[Ordinal(44)] [RED("wasSailFillSoundPlayed")] 		public CBool WasSailFillSoundPlayed { get; set;}

		[Ordinal(45)] [RED("boatMastTrailLoopStarted")] 		public CBool BoatMastTrailLoopStarted { get; set;}

		[Ordinal(46)] [RED("dismountStateName")] 		public CName DismountStateName { get; set;}

		[Ordinal(47)] [RED("localSpaceCameraTurnPercent")] 		public CFloat LocalSpaceCameraTurnPercent { get; set;}

		public CBoatComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBoatComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}