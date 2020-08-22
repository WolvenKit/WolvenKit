using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTask3StateAddEffectAttackDef : CBTTask3StateAttackDef
	{
		[RED("applyEffectInRange")] 		public CFloat ApplyEffectInRange { get; set;}

		[RED("applyEffectInCone")] 		public CFloat ApplyEffectInCone { get; set;}

		[RED("applyEffectInterval")] 		public CFloat ApplyEffectInterval { get; set;}

		[RED("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[RED("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[RED("effectValue")] 		public CFloat EffectValue { get; set;}

		[RED("effectPercentValue")] 		public CFloat EffectPercentValue { get; set;}

		public CBTTask3StateAddEffectAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTask3StateAddEffectAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}