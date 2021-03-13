using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameUnequipByTDBIDRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("itemTDBID")] public TweakDBID ItemTDBID { get; set; }

		public gameUnequipByTDBIDRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
