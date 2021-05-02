using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPhilippaAttractorTrigger : CGameplayEntity
	{
		[Ordinal(1)] [RED("actorTagToSendInfo")] 		public CName ActorTagToSendInfo { get; set;}

		[Ordinal(2)] [RED("triggeredByPlayer")] 		public CBool TriggeredByPlayer { get; set;}

		[Ordinal(3)] [RED("triggeredByBolts")] 		public CBool TriggeredByBolts { get; set;}

		[Ordinal(4)] [RED("triggeredByBombs")] 		public CBool TriggeredByBombs { get; set;}

		[Ordinal(5)] [RED("actor")] 		public CHandle<CActor> Actor { get; set;}

		[Ordinal(6)] [RED("lastActivation")] 		public CFloat LastActivation { get; set;}

		public CPhilippaAttractorTrigger(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPhilippaAttractorTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}