using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioMaterialOverride : CVariable
	{
		[Ordinal(0)]  [RED("base")] public CName Base { get; set; }
		[Ordinal(1)]  [RED("override")] public CName Override { get; set; }

		public audioMaterialOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
