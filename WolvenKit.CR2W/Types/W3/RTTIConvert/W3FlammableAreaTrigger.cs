using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3FlammableAreaTrigger : W3EffectAreaTrigger
	{
		[RED("activeFor")] 		public CFloat ActiveFor { get; set;}

		[RED("fxOnExplosion")] 		public CName FxOnExplosion { get; set;}

		[RED("fxOnSustain")] 		public CName FxOnSustain { get; set;}

		[RED("explosionRange")] 		public CFloat ExplosionRange { get; set;}

		[RED("explosionDamage")] 		public SAbilityAttributeValue ExplosionDamage { get; set;}

		[RED("igniteFlammableAreasAfter")] 		public CFloat IgniteFlammableAreasAfter { get; set;}

		[RED("isActive")] 		public CBool IsActive { get; set;}

		[RED("area")] 		public CHandle<CTriggerAreaComponent> Area { get; set;}

		public W3FlammableAreaTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3FlammableAreaTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}