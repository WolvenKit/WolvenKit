using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHorseJumpTrigger : CGameplayEntity
	{
		[Ordinal(0)] [RED("("lastActivation")] 		public CFloat LastActivation { get; set;}

		[Ordinal(0)] [RED("("triggerHeading")] 		public CFloat TriggerHeading { get; set;}

		[Ordinal(0)] [RED("("playerHeading")] 		public CFloat PlayerHeading { get; set;}

		[Ordinal(0)] [RED("("angleDist")] 		public CFloat AngleDist { get; set;}

		[Ordinal(0)] [RED("("horse")] 		public CHandle<CGameplayEntity> Horse { get; set;}

		[Ordinal(0)] [RED("("horseComp")] 		public CHandle<W3HorseComponent> HorseComp { get; set;}

		[Ordinal(0)] [RED("("lastArea")] 		public CHandle<CTriggerAreaComponent> LastArea { get; set;}

		public CHorseJumpTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHorseJumpTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}