using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_AddBuff : W3SwitchEvent
	{
		[RED("applyEffect")] 		public CEnum<EEffectType> ApplyEffect { get; set;}

		[RED("useDefaultValuesFromXML")] 		public CBool UseDefaultValuesFromXML { get; set;}

		[RED("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[RED("customDamageValuePerSec")] 		public SAbilityAttributeValue CustomDamageValuePerSec { get; set;}

		public W3SE_AddBuff(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3SE_AddBuff(cr2w);

	}
}