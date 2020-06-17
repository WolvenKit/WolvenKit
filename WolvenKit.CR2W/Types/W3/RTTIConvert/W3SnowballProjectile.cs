using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SnowballProjectile : W3AdvancedProjectile
	{
		[RED("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[RED("initFxName")] 		public CName InitFxName { get; set;}

		[RED("onCollisionFxName")] 		public CName OnCollisionFxName { get; set;}

		[RED("specialFxOnVictimName")] 		public CName SpecialFxOnVictimName { get; set;}

		[RED("applyDebuffIfNoDmgWasDealt")] 		public CBool ApplyDebuffIfNoDmgWasDealt { get; set;}

		public W3SnowballProjectile(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3SnowballProjectile(cr2w);

	}
}