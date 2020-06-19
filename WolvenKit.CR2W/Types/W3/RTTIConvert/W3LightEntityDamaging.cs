using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LightEntityDamaging : CLightEntitySimple
	{
		[RED("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[RED("damagePerSec")] 		public CFloat DamagePerSec { get; set;}

		[RED("appliesBurning")] 		public CBool AppliesBurning { get; set;}

		public W3LightEntityDamaging(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LightEntityDamaging(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}