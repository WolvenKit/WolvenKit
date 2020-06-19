using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3EffectAreaTrigger : CGameplayEntity
	{
		[RED("effect")] 		public CEnum<EEffectType> Effect { get; set;}

		[RED("useDefaultValuesFromXML")] 		public CBool UseDefaultValuesFromXML { get; set;}

		[RED("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[RED("customDamageValuePerSec")] 		public SAbilityAttributeValue CustomDamageValuePerSec { get; set;}

		[RED("immunityFact")] 		public CString ImmunityFact { get; set;}

		[RED("customParams")] 		public CHandle<W3BuffCustomParams> CustomParams { get; set;}

		public W3EffectAreaTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3EffectAreaTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}