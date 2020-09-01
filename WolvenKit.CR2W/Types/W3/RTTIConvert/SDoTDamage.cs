using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDoTDamage : CVariable
	{
		[Ordinal(1)] [RED("("damageTypeName")] 		public CName DamageTypeName { get; set;}

		[Ordinal(2)] [RED("("hitsVitality")] 		public CBool HitsVitality { get; set;}

		[Ordinal(3)] [RED("("hitsEssence")] 		public CBool HitsEssence { get; set;}

		[Ordinal(4)] [RED("("resistance")] 		public CEnum<ECharacterDefenseStats> Resistance { get; set;}

		public SDoTDamage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDoTDamage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}