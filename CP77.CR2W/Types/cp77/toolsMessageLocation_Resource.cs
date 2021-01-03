using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class toolsMessageLocation_Resource : toolsIMessageLocation
	{
		[Ordinal(0)]  [RED("path")] public MessageResourcePath Path { get; set; }

		public toolsMessageLocation_Resource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
