using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkHudEntryInfo : inkUserData
	{
		[Ordinal(0)]  [RED("offset")] public Vector2 Offset { get; set; }
		[Ordinal(1)]  [RED("size")] public Vector2 Size { get; set; }

		public inkHudEntryInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
