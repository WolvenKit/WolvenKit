using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDamageAreaEntity : CInteractiveEntity
	{
		[Ordinal(0)] [RED("("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(0)] [RED("("buff")] 		public CEnum<EEffectType> Buff { get; set;}

		[Ordinal(0)] [RED("("buffDuration")] 		public CFloat BuffDuration { get; set;}

		[Ordinal(0)] [RED("("customDamageValuePerSec")] 		public SAbilityAttributeValue CustomDamageValuePerSec { get; set;}

		[Ordinal(0)] [RED("("effectOnSpawn")] 		public CName EffectOnSpawn { get; set;}

		[Ordinal(0)] [RED("("activeFor")] 		public CFloat ActiveFor { get; set;}

		[Ordinal(0)] [RED("("stopSpawnEffectDelay")] 		public CFloat StopSpawnEffectDelay { get; set;}

		[Ordinal(0)] [RED("("dealDamagePerc")] 		public CInt32 DealDamagePerc { get; set;}

		[Ordinal(0)] [RED("("range")] 		public CFloat Range { get; set;}

		[Ordinal(0)] [RED("("isActive")] 		public CBool IsActive { get; set;}

		[Ordinal(0)] [RED("("actorsInRange", 2,0)] 		public CArray<CHandle<CActor>> ActorsInRange { get; set;}

		[Ordinal(0)] [RED("("buffParams")] 		public SCustomEffectParams BuffParams { get; set;}

		[Ordinal(0)] [RED("("interaction")] 		public CHandle<CInteractionComponent> Interaction { get; set;}

		public CDamageAreaEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDamageAreaEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}