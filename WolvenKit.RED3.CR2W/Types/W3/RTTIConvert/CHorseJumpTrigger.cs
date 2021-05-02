using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CHorseJumpTrigger : CGameplayEntity
	{
		[Ordinal(1)] [RED("lastActivation")] 		public CFloat LastActivation { get; set;}

		[Ordinal(2)] [RED("triggerHeading")] 		public CFloat TriggerHeading { get; set;}

		[Ordinal(3)] [RED("playerHeading")] 		public CFloat PlayerHeading { get; set;}

		[Ordinal(4)] [RED("angleDist")] 		public CFloat AngleDist { get; set;}

		[Ordinal(5)] [RED("horse")] 		public CHandle<CGameplayEntity> Horse { get; set;}

		[Ordinal(6)] [RED("horseComp")] 		public CHandle<W3HorseComponent> HorseComp { get; set;}

		[Ordinal(7)] [RED("lastArea")] 		public CHandle<CTriggerAreaComponent> LastArea { get; set;}

		public CHorseJumpTrigger(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CHorseJumpTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}