using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioCookedMetadataResource : CResource
	{
		[Ordinal(0)]  [RED("entries")] public CArray<CHandle<audioAudioMetadata>> Entries { get; set; }

		public audioCookedMetadataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
