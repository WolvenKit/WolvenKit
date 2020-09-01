using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SnowballProjectile : W3AdvancedProjectile
	{
		[Ordinal(0)] [RED("("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[Ordinal(0)] [RED("("initFxName")] 		public CName InitFxName { get; set;}

		[Ordinal(0)] [RED("("onCollisionFxName")] 		public CName OnCollisionFxName { get; set;}

		[Ordinal(0)] [RED("("specialFxOnVictimName")] 		public CName SpecialFxOnVictimName { get; set;}

		[Ordinal(0)] [RED("("applyDebuffIfNoDmgWasDealt")] 		public CBool ApplyDebuffIfNoDmgWasDealt { get; set;}

		public W3SnowballProjectile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SnowballProjectile(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}