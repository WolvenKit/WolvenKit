using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTask3StateAddEffectAttack : CBTTask3StateAttack
	{
		[Ordinal(0)] [RED("("applyEffectInRange")] 		public CFloat ApplyEffectInRange { get; set;}

		[Ordinal(0)] [RED("("applyEffectInCone")] 		public CFloat ApplyEffectInCone { get; set;}

		[Ordinal(0)] [RED("("applyEffectInterval")] 		public CFloat ApplyEffectInterval { get; set;}

		[Ordinal(0)] [RED("("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[Ordinal(0)] [RED("("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[Ordinal(0)] [RED("("effectValue")] 		public CFloat EffectValue { get; set;}

		[Ordinal(0)] [RED("("effectPercentValue")] 		public CFloat EffectPercentValue { get; set;}

		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		public CBTTask3StateAddEffectAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTask3StateAddEffectAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}