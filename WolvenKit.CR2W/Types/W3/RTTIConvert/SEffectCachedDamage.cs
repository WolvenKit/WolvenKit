using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEffectCachedDamage : CVariable
	{
		[Ordinal(1)] [RED("dmgType")] 		public CName DmgType { get; set;}

		[Ordinal(2)] [RED("attacker")] 		public EntityHandle Attacker { get; set;}

		[Ordinal(3)] [RED("carrier")] 		public CHandle<CBaseGameplayEffect> Carrier { get; set;}

		[Ordinal(4)] [RED("dmgVal")] 		public CFloat DmgVal { get; set;}

		[Ordinal(5)] [RED("dt")] 		public CFloat Dt { get; set;}

		[Ordinal(6)] [RED("dontShowHitParticle")] 		public CBool DontShowHitParticle { get; set;}

		[Ordinal(7)] [RED("powerStatType")] 		public CEnum<ECharacterPowerStats> PowerStatType { get; set;}

		[Ordinal(8)] [RED("isEnvironment")] 		public CBool IsEnvironment { get; set;}

		[Ordinal(9)] [RED("sourceName")] 		public CString SourceName { get; set;}

		public SEffectCachedDamage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEffectCachedDamage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}