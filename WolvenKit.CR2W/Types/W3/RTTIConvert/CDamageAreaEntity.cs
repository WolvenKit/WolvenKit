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

		[RED("buff")] 		public CEnum<EEffectType> Buff { get; set;}

		[RED("buffDuration")] 		public CFloat BuffDuration { get; set;}

		[RED("customDamageValuePerSec")] 		public SAbilityAttributeValue CustomDamageValuePerSec { get; set;}

		[RED("effectOnSpawn")] 		public CName EffectOnSpawn { get; set;}

		[RED("activeFor")] 		public CFloat ActiveFor { get; set;}

		[RED("stopSpawnEffectDelay")] 		public CFloat StopSpawnEffectDelay { get; set;}

		[RED("dealDamagePerc")] 		public CInt32 DealDamagePerc { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		public CDamageAreaEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDamageAreaEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}