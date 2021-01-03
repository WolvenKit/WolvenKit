using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SDevelopmentPoints : CVariable
	{
		[Ordinal(0)]  [RED("spent")] public CInt32 Spent { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<gamedataDevelopmentPointType> Type { get; set; }
		[Ordinal(2)]  [RED("unspent")] public CInt32 Unspent { get; set; }

		public SDevelopmentPoints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
