using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FocusCluesSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("activeLinkedClue")] public LinkedFocusClueData ActiveLinkedClue { get; set; }
		[Ordinal(1)]  [RED("disabledGroupes")] public CArray<CName> DisabledGroupes { get; set; }
		[Ordinal(2)]  [RED("linkedClues")] public CArray<LinkedFocusClueData> LinkedClues { get; set; }

		public FocusCluesSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
