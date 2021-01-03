using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class saveMetadataContainer : ISerializable
	{
		[Ordinal(0)]  [RED("metadata")] public saveMetadata Metadata { get; set; }

		public saveMetadataContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
