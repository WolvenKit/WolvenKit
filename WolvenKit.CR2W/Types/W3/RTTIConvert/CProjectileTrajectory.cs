using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CProjectileTrajectory : CGameplayEntity
	{
		[Ordinal(0)] [RED("projectileName")] 		public CName ProjectileName { get; set;}

		[Ordinal(0)] [RED("animatedOffset")] 		public Vector AnimatedOffset { get; set;}

		[Ordinal(0)] [RED("animatedTimeMultiplier")] 		public CFloat AnimatedTimeMultiplier { get; set;}

		[Ordinal(0)] [RED("bounceOfVelocityPreserve")] 		public CFloat BounceOfVelocityPreserve { get; set;}

		[Ordinal(0)] [RED("overlapAccuracy")] 		public CFloat OverlapAccuracy { get; set;}

		[Ordinal(0)] [RED("doWaterLevelTest")] 		public CBool DoWaterLevelTest { get; set;}

		[Ordinal(0)] [RED("waterTestAccuracy")] 		public CFloat WaterTestAccuracy { get; set;}

		[Ordinal(0)] [RED("caster")] 		public CHandle<CEntity> Caster { get; set;}

		[Ordinal(0)] [RED("realCaster")] 		public CHandle<CEntity> RealCaster { get; set;}

		[Ordinal(0)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(0)] [RED("alarmRadius")] 		public CFloat AlarmRadius { get; set;}

		[Ordinal(0)] [RED("victim")] 		public CHandle<CGameplayEntity> Victim { get; set;}

		[Ordinal(0)] [RED("yrdenAlternate")] 		public CHandle<W3YrdenEntity> YrdenAlternate { get; set;}

		public CProjectileTrajectory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CProjectileTrajectory(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}