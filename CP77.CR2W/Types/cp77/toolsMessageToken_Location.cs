using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class toolsMessageToken_Location : toolsIMessageToken
	{
		[Ordinal(0)]  [RED("location")] public CHandle<toolsIMessageLocation> Location { get; set; }

		public toolsMessageToken_Location(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
