using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEffectInfo : CVariable
	{
		[RED("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[RED("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[RED("effectAbilityName")] 		public CName EffectAbilityName { get; set;}

		[RED("customFXName")] 		public CName CustomFXName { get; set;}

		[RED("effectCustomValue")] 		public SAbilityAttributeValue EffectCustomValue { get; set;}

		[RED("effectCustomParam")] 		public CHandle<W3BuffCustomParams> EffectCustomParam { get; set;}

		[RED("applyChance")] 		public CFloat ApplyChance { get; set;}

		public SEffectInfo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SEffectInfo(cr2w);

	}
}