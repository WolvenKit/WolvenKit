using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DialogueChoiceHubPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("isChoiceHubActive")] public CBool IsChoiceHubActive { get; set; }

		public DialogueChoiceHubPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
