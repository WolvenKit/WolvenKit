using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskTornadoAttackDef : CBTTaskAttackDef
	{
		[RED("minCameraShakeStrength")] 		public CFloat MinCameraShakeStrength { get; set;}

		[RED("maxCameraShakeStrength")] 		public CFloat MaxCameraShakeStrength { get; set;}

		[RED("cameraShakeRange")] 		public CFloat CameraShakeRange { get; set;}

		[RED("cameraShakeInterval")] 		public CFloat CameraShakeInterval { get; set;}

		[RED("victimTestInterval")] 		public CFloat VictimTestInterval { get; set;}

		[RED("debuffInterval")] 		public CFloat DebuffInterval { get; set;}

		[RED("damageInterval")] 		public CFloat DamageInterval { get; set;}

		[RED("damageMultiplier")] 		public CFloat DamageMultiplier { get; set;}

		[RED("affectEnemiesInRangeMin")] 		public CFloat AffectEnemiesInRangeMin { get; set;}

		[RED("affectEnemiesInRangeMax")] 		public CFloat AffectEnemiesInRangeMax { get; set;}

		[RED("castingLoopTime")] 		public CFloat CastingLoopTime { get; set;}

		[RED("setBehVarOnDeactivation")] 		public CName SetBehVarOnDeactivation { get; set;}

		[RED("setBehVarValueOnDeactivation")] 		public CFloat SetBehVarValueOnDeactivation { get; set;}

		[RED("debuffTypeInRangeMin")] 		public CEnum<EEffectType> DebuffTypeInRangeMin { get; set;}

		[RED("rotateToNodeByTagOnDebuffMin")] 		public CName RotateToNodeByTagOnDebuffMin { get; set;}

		[RED("debuffTypeInRangeMax")] 		public CEnum<EEffectType> DebuffTypeInRangeMax { get; set;}

		[RED("debuffDurationInRangeMin")] 		public CFloat DebuffDurationInRangeMin { get; set;}

		[RED("debuffDurationInRangeMax")] 		public CFloat DebuffDurationInRangeMax { get; set;}

		[RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[RED("additionalFxOnDamageVictim")] 		public CName AdditionalFxOnDamageVictim { get; set;}

		public CBTTaskTornadoAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskTornadoAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}