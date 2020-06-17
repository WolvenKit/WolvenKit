using System.IO;using System.Runtime.Serialization;
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

		public W3FlammableAreaTrigger(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3FlammableAreaTrigger(cr2w);

	}
}