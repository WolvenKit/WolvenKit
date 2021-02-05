using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsMaterialLibraryResource : CResource
	{
		[Ordinal(0)]  [RED("defaultMaterial")] public CHandle<physicsMaterialResource> DefaultMaterial { get; set; }
		[Ordinal(1)]  [RED("collectionData")] public DataBuffer CollectionData { get; set; }

		public physicsMaterialLibraryResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
