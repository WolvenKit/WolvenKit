using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsMaterialLibraryResource_ : CResource
	{
		[Ordinal(1)] [RED("defaultMaterial")] public CHandle<physicsMaterialResource> DefaultMaterial { get; set; }
		[Ordinal(2)] [RED("collectionData")] public DataBuffer CollectionData { get; set; }

		public physicsMaterialLibraryResource_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
