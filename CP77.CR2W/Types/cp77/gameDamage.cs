using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameDamage : IScriptable
	{
		[Ordinal(0)]  [RED("damageType")] public CEnum<gamedataDamageType> DamageType { get; set; }
		[Ordinal(1)]  [RED("value")] public CFloat Value { get; set; }

		public gameDamage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
