using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEffectCachedDamage : CVariable
	{
		[RED("dmgType")] 		public CName DmgType { get; set;}

		[RED("attacker")] 		public EntityHandle Attacker { get; set;}

		[RED("carrier")] 		public CHandle<CBaseGameplayEffect> Carrier { get; set;}

		[RED("dmgVal")] 		public CFloat DmgVal { get; set;}

		[RED("dt")] 		public CFloat Dt { get; set;}

		[RED("dontShowHitParticle")] 		public CBool DontShowHitParticle { get; set;}

		[RED("powerStatType")] 		public CEnum<ECharacterPowerStats> PowerStatType { get; set;}

		[RED("isEnvironment")] 		public CBool IsEnvironment { get; set;}

		[RED("sourceName")] 		public CString SourceName { get; set;}

		public SEffectCachedDamage(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SEffectCachedDamage(cr2w);

	}
}