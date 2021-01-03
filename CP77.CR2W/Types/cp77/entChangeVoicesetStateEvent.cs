using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entChangeVoicesetStateEvent : redEvent
	{
		[Ordinal(0)]  [RED("enableVoicesetGrunts")] public CBool EnableVoicesetGrunts { get; set; }
		[Ordinal(1)]  [RED("enableVoicesetLines")] public CBool EnableVoicesetLines { get; set; }
		[Ordinal(2)]  [RED("inputsToBlock")] public CArray<entVoicesetInputToBlock> InputsToBlock { get; set; }

		public entChangeVoicesetStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
