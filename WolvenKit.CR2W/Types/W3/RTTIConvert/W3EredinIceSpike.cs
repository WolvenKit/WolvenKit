using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3EredinIceSpike : W3DurationObstacle
	{
		[RED("explodeAfter")] 		public CFloat ExplodeAfter { get; set;}

		[RED("damageRadius")] 		public CFloat DamageRadius { get; set;}

		[RED("damageVal")] 		public CFloat DamageVal { get; set;}

		[RED("effectDuration")] 		public CFloat EffectDuration { get; set;}

		public W3EredinIceSpike(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3EredinIceSpike(cr2w);

	}
}