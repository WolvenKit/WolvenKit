using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entEntityTemplate : resStreamedResource
	{
		[Ordinal(0)]  [RED("includes")] public CArray<entTemplateInclude> Includes { get; set; }
		[Ordinal(1)]  [RED("appearances")] public CArray<entTemplateAppearance> Appearances { get; set; }
		[Ordinal(2)]  [RED("defaultAppearance")] public CName DefaultAppearance { get; set; }
		[Ordinal(3)]  [RED("componentResolveSettings")] public CArray<entTemplateComponentResolveSettings> ComponentResolveSettings { get; set; }
		[Ordinal(4)]  [RED("bindingOverrides")] public CArray<entTemplateBindingOverride> BindingOverrides { get; set; }
		[Ordinal(5)]  [RED("backendDataOverrides")] public CArray<entTemplateComponentBackendDataOverrideInfo> BackendDataOverrides { get; set; }
		[Ordinal(6)]  [RED("visualTagsSchema")] public CHandle<entVisualTagsSchema> VisualTagsSchema { get; set; }
		[Ordinal(7)]  [RED("localData")] public DataBuffer LocalData { get; set; }
		[Ordinal(8)]  [RED("includeInstanceBuffer")] public DataBuffer IncludeInstanceBuffer { get; set; }
		[Ordinal(9)]  [RED("compiledData")] public DataBuffer CompiledData { get; set; }
		[Ordinal(10)]  [RED("resolvedDependencies")] public CArray<raRef<CResource>> ResolvedDependencies { get; set; }
		[Ordinal(11)]  [RED("inplaceResources")] public CArray<rRef<CResource>> InplaceResources { get; set; }
		[Ordinal(12)]  [RED("compiledEntityLODFlags")] public CUInt16 CompiledEntityLODFlags { get; set; }

		public entEntityTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
