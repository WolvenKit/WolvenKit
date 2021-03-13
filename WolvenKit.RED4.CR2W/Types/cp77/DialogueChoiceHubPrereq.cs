using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DialogueChoiceHubPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("isChoiceHubActive")] public CBool IsChoiceHubActive { get; set; }

		public DialogueChoiceHubPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
