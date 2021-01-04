using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questChangeVoicesetState_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("enableVoicesetGrunts")] public CBool EnableVoicesetGrunts { get; set; }
		[Ordinal(1)]  [RED("enableVoicesetLines")] public CBool EnableVoicesetLines { get; set; }
		[Ordinal(2)]  [RED("inputsToBlock")] public CArray<entVoicesetInputToBlock> InputsToBlock { get; set; }
		[Ordinal(3)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(4)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }

		public questChangeVoicesetState_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
