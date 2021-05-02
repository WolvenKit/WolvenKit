using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SnowballProjectile : W3AdvancedProjectile
	{
		[Ordinal(1)] [RED("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[Ordinal(2)] [RED("initFxName")] 		public CName InitFxName { get; set;}

		[Ordinal(3)] [RED("onCollisionFxName")] 		public CName OnCollisionFxName { get; set;}

		[Ordinal(4)] [RED("specialFxOnVictimName")] 		public CName SpecialFxOnVictimName { get; set;}

		[Ordinal(5)] [RED("applyDebuffIfNoDmgWasDealt")] 		public CBool ApplyDebuffIfNoDmgWasDealt { get; set;}

		public W3SnowballProjectile(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SnowballProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}