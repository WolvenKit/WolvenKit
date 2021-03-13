using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CProjectileTrajectory : CGameplayEntity
	{
		[Ordinal(1)] [RED("projectileName")] 		public CName ProjectileName { get; set;}

		[Ordinal(2)] [RED("animatedOffset")] 		public Vector AnimatedOffset { get; set;}

		[Ordinal(3)] [RED("animatedTimeMultiplier")] 		public CFloat AnimatedTimeMultiplier { get; set;}

		[Ordinal(4)] [RED("bounceOfVelocityPreserve")] 		public CFloat BounceOfVelocityPreserve { get; set;}

		[Ordinal(5)] [RED("overlapAccuracy")] 		public CFloat OverlapAccuracy { get; set;}

		[Ordinal(6)] [RED("doWaterLevelTest")] 		public CBool DoWaterLevelTest { get; set;}

		[Ordinal(7)] [RED("waterTestAccuracy")] 		public CFloat WaterTestAccuracy { get; set;}

		[Ordinal(8)] [RED("caster")] 		public CHandle<CEntity> Caster { get; set;}

		[Ordinal(9)] [RED("realCaster")] 		public CHandle<CEntity> RealCaster { get; set;}

		[Ordinal(10)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(11)] [RED("alarmRadius")] 		public CFloat AlarmRadius { get; set;}

		[Ordinal(12)] [RED("victim")] 		public CHandle<CGameplayEntity> Victim { get; set;}

		[Ordinal(13)] [RED("yrdenAlternate")] 		public CHandle<W3YrdenEntity> YrdenAlternate { get; set;}

		public CProjectileTrajectory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CProjectileTrajectory(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}