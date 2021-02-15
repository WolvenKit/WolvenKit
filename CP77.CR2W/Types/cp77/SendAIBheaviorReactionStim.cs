using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SendAIBheaviorReactionStim : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("stimToSend")] public CEnum<gamedataStimType> StimToSend { get; set; }

		public SendAIBheaviorReactionStim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
