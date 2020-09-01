using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskTornadoAttackDef : CBTTaskAttackDef
	{
		[Ordinal(0)] [RED("("minCameraShakeStrength")] 		public CFloat MinCameraShakeStrength { get; set;}

		[Ordinal(0)] [RED("("maxCameraShakeStrength")] 		public CFloat MaxCameraShakeStrength { get; set;}

		[Ordinal(0)] [RED("("cameraShakeRange")] 		public CFloat CameraShakeRange { get; set;}

		[Ordinal(0)] [RED("("cameraShakeInterval")] 		public CFloat CameraShakeInterval { get; set;}

		[Ordinal(0)] [RED("("victimTestInterval")] 		public CFloat VictimTestInterval { get; set;}

		[Ordinal(0)] [RED("("debuffInterval")] 		public CFloat DebuffInterval { get; set;}

		[Ordinal(0)] [RED("("damageInterval")] 		public CFloat DamageInterval { get; set;}

		[Ordinal(0)] [RED("("damageMultiplier")] 		public CFloat DamageMultiplier { get; set;}

		[Ordinal(0)] [RED("("affectEnemiesInRangeMin")] 		public CFloat AffectEnemiesInRangeMin { get; set;}

		[Ordinal(0)] [RED("("affectEnemiesInRangeMax")] 		public CFloat AffectEnemiesInRangeMax { get; set;}

		[Ordinal(0)] [RED("("castingLoopTime")] 		public CFloat CastingLoopTime { get; set;}

		[Ordinal(0)] [RED("("setBehVarOnDeactivation")] 		public CName SetBehVarOnDeactivation { get; set;}

		[Ordinal(0)] [RED("("setBehVarValueOnDeactivation")] 		public CFloat SetBehVarValueOnDeactivation { get; set;}

		[Ordinal(0)] [RED("("debuffTypeInRangeMin")] 		public CEnum<EEffectType> DebuffTypeInRangeMin { get; set;}

		[Ordinal(0)] [RED("("rotateToNodeByTagOnDebuffMin")] 		public CName RotateToNodeByTagOnDebuffMin { get; set;}

		[Ordinal(0)] [RED("("debuffTypeInRangeMax")] 		public CEnum<EEffectType> DebuffTypeInRangeMax { get; set;}

		[Ordinal(0)] [RED("("debuffDurationInRangeMin")] 		public CFloat DebuffDurationInRangeMin { get; set;}

		[Ordinal(0)] [RED("("debuffDurationInRangeMax")] 		public CFloat DebuffDurationInRangeMax { get; set;}

		[Ordinal(0)] [RED("("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("("additionalFxOnDamageVictim")] 		public CName AdditionalFxOnDamageVictim { get; set;}

		public CBTTaskTornadoAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskTornadoAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}