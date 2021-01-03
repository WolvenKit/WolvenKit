using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HUDClueData : CVariable
	{
		[Ordinal(0)]  [RED("clueGroupID")] public CName ClueGroupID { get; set; }
		[Ordinal(1)]  [RED("isClue")] public CBool IsClue { get; set; }

		public HUDClueData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
