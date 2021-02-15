using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class saveMetadataContainer : ISerializable
	{
		[Ordinal(0)] [RED("metadata")] public saveMetadata Metadata { get; set; }

		public saveMetadataContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
