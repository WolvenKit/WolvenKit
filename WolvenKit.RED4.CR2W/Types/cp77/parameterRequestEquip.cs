using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class parameterRequestEquip : IScriptable
	{
		[Ordinal(0)] [RED("valid")] public CBool Valid { get; set; }
		[Ordinal(1)] [RED("itemID")] public gameItemID ItemID { get; set; }

		public parameterRequestEquip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
