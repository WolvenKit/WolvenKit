using System.IO;using System.Runtime.Serialization;
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

		public CPhilippaAttractorTrigger(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CPhilippaAttractorTrigger(cr2w);

	}
}