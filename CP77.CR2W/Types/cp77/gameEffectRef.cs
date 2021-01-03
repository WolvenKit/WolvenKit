using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectRef : CVariable
	{
		[Ordinal(0)]  [RED("set")] public rRef<gameEffectSet> Set { get; set; }
		[Ordinal(1)]  [RED("tag")] public CName Tag { get; set; }

		public gameEffectRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
