using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_AddBuff : W3SwitchEvent
	{
		[Ordinal(1)] [RED("applyEffect")] 		public CEnum<EEffectType> ApplyEffect { get; set;}

		[Ordinal(2)] [RED("useDefaultValuesFromXML")] 		public CBool UseDefaultValuesFromXML { get; set;}

		[Ordinal(3)] [RED("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[Ordinal(4)] [RED("customDamageValuePerSec")] 		public SAbilityAttributeValue CustomDamageValuePerSec { get; set;}

		public W3SE_AddBuff(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3SE_AddBuff(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}