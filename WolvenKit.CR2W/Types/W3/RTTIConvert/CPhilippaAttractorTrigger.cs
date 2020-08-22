using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPhilippaAttractorTrigger : CGameplayEntity
	{
		[RED("actorTagToSendInfo")] 		public CName ActorTagToSendInfo { get; set;}

		[RED("triggeredByPlayer")] 		public CBool TriggeredByPlayer { get; set;}

		[RED("triggeredByBolts")] 		public CBool TriggeredByBolts { get; set;}

		[RED("triggeredByBombs")] 		public CBool TriggeredByBombs { get; set;}

		[RED("actor")] 		public CHandle<CActor> Actor { get; set;}

		[RED("lastActivation")] 		public CFloat LastActivation { get; set;}

		public CPhilippaAttractorTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPhilippaAttractorTrigger(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}