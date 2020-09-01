using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStatePrepareJump : CExplorationStateAbstract
	{
		[Ordinal(0)] [RED("m_JumpIsInstantB")] 		public CBool M_JumpIsInstantB { get; set;}

		[Ordinal(0)] [RED("m_JumpTimeGapF")] 		public CFloat M_JumpTimeGapF { get; set;}

		[Ordinal(0)] [RED("m_EndingTimeF")] 		public CFloat M_EndingTimeF { get; set;}

		[Ordinal(0)] [RED("m_EndEventNameN")] 		public CName M_EndEventNameN { get; set;}

		[Ordinal(0)] [RED("m_EndedEventNameN")] 		public CName M_EndedEventNameN { get; set;}

		[Ordinal(0)] [RED("m_TimeEndedB")] 		public CBool M_TimeEndedB { get; set;}

		public CExplorationStatePrepareJump(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStatePrepareJump(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}