using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CProjectileTrajectory : CGameplayEntity
	{
		[RED("projectileName")] 		public CName ProjectileName { get; set;}

		[RED("animatedOffset")] 		public Vector AnimatedOffset { get; set;}

		[RED("animatedTimeMultiplier")] 		public CFloat AnimatedTimeMultiplier { get; set;}

		[RED("bounceOfVelocityPreserve")] 		public CFloat BounceOfVelocityPreserve { get; set;}

		[RED("overlapAccuracy")] 		public CFloat OverlapAccuracy { get; set;}

		[RED("doWaterLevelTest")] 		public CBool DoWaterLevelTest { get; set;}

		[RED("waterTestAccuracy")] 		public CFloat WaterTestAccuracy { get; set;}

		[RED("caster")] 		public CHandle<CEntity> Caster { get; set;}

		[RED("realCaster")] 		public CHandle<CEntity> RealCaster { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("alarmRadius")] 		public CFloat AlarmRadius { get; set;}

		public CProjectileTrajectory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CProjectileTrajectory(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}