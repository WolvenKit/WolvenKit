using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryResource : CResource
	{
		[Ordinal(0)]  [RED("rootResolution")] public CEnum<inkETextureResolution> RootResolution { get; set; }
		[Ordinal(1)]  [RED("rootDefinitionIndex")] public CUInt32 RootDefinitionIndex { get; set; }
		[Ordinal(2)]  [RED("libraryItems")] public CArray<inkWidgetLibraryItem> LibraryItems { get; set; }
		[Ordinal(3)]  [RED("externalLibraries")] public CArray<rRef<inkWidgetLibraryResource>> ExternalLibraries { get; set; }
		[Ordinal(4)]  [RED("animationLibraryResRef")] public raRef<inkanimAnimationLibraryResource> AnimationLibraryResRef { get; set; }
		[Ordinal(5)]  [RED("sequences")] public CArray<CHandle<inkanimSequence>> Sequences { get; set; }
		[Ordinal(6)]  [RED("externalDependenciesForInternalItems")] public CArray<raRef<CResource>> ExternalDependenciesForInternalItems { get; set; }
		[Ordinal(7)]  [RED("version")] public CEnum<inkWidgetResourceVersion> Version { get; set; }

		public inkWidgetLibraryResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
