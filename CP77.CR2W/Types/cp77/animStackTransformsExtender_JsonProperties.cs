using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animStackTransformsExtender_JsonProperties : ISerializable
	{
		[Ordinal(0)]  [RED("entries")] public CArray<animStackTransformsExtender_JsonEntry> Entries { get; set; }

		public animStackTransformsExtender_JsonProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
