using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCpoArmouryItem : gameObject
	{
		[Ordinal(40)] [RED("armouryItemID")] public TweakDBID ArmouryItemID { get; set; }

		public gameCpoArmouryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
