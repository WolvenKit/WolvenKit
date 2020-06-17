using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestBehaviorEventBlock : CQuestGraphBlock
	{
		[RED("events", 2,0)] 		public CArray<CPtr<SQuestBehaviorEvent>> Events { get; set;}

		[RED("timeout")] 		public CFloat Timeout { get; set;}

		public CQuestBehaviorEventBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestBehaviorEventBlock(cr2w);

	}
}