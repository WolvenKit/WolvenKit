using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiBinkResource : CVariable
	{
		[Ordinal(0)]  [RED("video")] public raRef<Bink> Video { get; set; }

		public gameuiBinkResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
