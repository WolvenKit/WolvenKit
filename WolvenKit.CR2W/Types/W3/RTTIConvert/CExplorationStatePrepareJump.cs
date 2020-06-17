using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStatePrepareJump : CExplorationStateAbstract
	{
		[RED("m_JumpIsInstantB")] 		public CBool M_JumpIsInstantB { get; set;}

		[RED("m_JumpTimeGapF")] 		public CFloat M_JumpTimeGapF { get; set;}

		[RED("m_EndingTimeF")] 		public CFloat M_EndingTimeF { get; set;}

		[RED("m_EndEventNameN")] 		public CName M_EndEventNameN { get; set;}

		[RED("m_EndedEventNameN")] 		public CName M_EndedEventNameN { get; set;}

		[RED("m_TimeEndedB")] 		public CBool M_TimeEndedB { get; set;}

		public CExplorationStatePrepareJump(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStatePrepareJump(cr2w);

	}
}