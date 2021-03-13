using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisDialogChoiceHubs : CVariable
	{
		[Ordinal(0)] [RED("choiceHubs")] public CArray<gameinteractionsvisListChoiceHubData> ChoiceHubs { get; set; }

		public gameinteractionsvisDialogChoiceHubs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
