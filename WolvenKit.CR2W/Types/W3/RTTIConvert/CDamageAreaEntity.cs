using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDamageAreaEntity : CInteractiveEntity
	{
		[RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[RED("buff")] 		public EEffectType Buff { get; set;}

		[RED("buffDuration")] 		public CFloat BuffDuration { get; set;}

		[RED("customDamageValuePerSec")] 		public SAbilityAttributeValue CustomDamageValuePerSec { get; set;}

		[RED("effectOnSpawn")] 		public CName EffectOnSpawn { get; set;}

		[RED("activeFor")] 		public CFloat ActiveFor { get; set;}

		[RED("stopSpawnEffectDelay")] 		public CFloat StopSpawnEffectDelay { get; set;}

		[RED("dealDamagePerc")] 		public CInt32 DealDamagePerc { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		public CDamageAreaEntity(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CDamageAreaEntity(cr2w);

	}
}