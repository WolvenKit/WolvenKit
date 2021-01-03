using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WeaponTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(0)]  [RED("type")] public CName Type { get; set; }

		public WeaponTypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
