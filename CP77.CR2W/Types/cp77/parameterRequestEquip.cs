using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class parameterRequestEquip : IScriptable
	{
		[Ordinal(0)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)]  [RED("valid")] public CBool Valid { get; set; }

		public parameterRequestEquip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
