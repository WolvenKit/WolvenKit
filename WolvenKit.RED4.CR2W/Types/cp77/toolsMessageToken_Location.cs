using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsMessageToken_Location : toolsIMessageToken
	{
		[Ordinal(0)] [RED("location")] public CHandle<toolsIMessageLocation> Location { get; set; }

		public toolsMessageToken_Location(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
