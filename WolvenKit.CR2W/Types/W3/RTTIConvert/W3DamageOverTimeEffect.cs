using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3DamageOverTimeEffect : CBaseGameplayEffect
	{
		[Ordinal(1)] [RED("damages", 2,0)] 		public CArray<SDoTDamage> Damages { get; set;}

		[Ordinal(2)] [RED("powerStatType")] 		public CEnum<ECharacterPowerStats> PowerStatType { get; set;}

		[Ordinal(3)] [RED("isEnvironment")] 		public CBool IsEnvironment { get; set;}

		[Ordinal(4)] [RED("hpRegenPauseStrength")] 		public SAbilityAttributeValue HpRegenPauseStrength { get; set;}

		[Ordinal(5)] [RED("hpRegenPauseExtraDuration")] 		public CFloat HpRegenPauseExtraDuration { get; set;}

		public W3DamageOverTimeEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3DamageOverTimeEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}