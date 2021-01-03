using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisDialogChoiceHubs : CVariable
	{
		[Ordinal(0)]  [RED("choiceHubs")] public CArray<gameinteractionsvisListChoiceHubData> ChoiceHubs { get; set; }

		public gameinteractionsvisDialogChoiceHubs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
