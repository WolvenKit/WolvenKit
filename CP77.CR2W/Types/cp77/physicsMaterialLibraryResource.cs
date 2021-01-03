using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsMaterialLibraryResource : CResource
	{
		[Ordinal(0)]  [RED("collectionData")] public DataBuffer CollectionData { get; set; }
		[Ordinal(1)]  [RED("defaultMaterial")] public CHandle<physicsMaterialResource> DefaultMaterial { get; set; }

		public physicsMaterialLibraryResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
