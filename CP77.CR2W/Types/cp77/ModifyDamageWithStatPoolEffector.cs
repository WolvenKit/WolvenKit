using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageWithStatPoolEffector : ModifyDamageEffector
	{
		[Ordinal(0)]  [RED("maxDmg")] public CFloat MaxDmg { get; set; }
		[Ordinal(1)]  [RED("poolStatus")] public CString PoolStatus { get; set; }
		[Ordinal(2)]  [RED("refObj")] public CString RefObj { get; set; }
		[Ordinal(3)]  [RED("statPool")] public CEnum<gamedataStatPoolType> StatPool { get; set; }

		public ModifyDamageWithStatPoolEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
