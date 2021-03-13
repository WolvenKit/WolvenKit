using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialTemplate_ : IMaterialDefinition
	{
		[Ordinal(8)] [RED("name")] public CName Name { get; set; }
		[Ordinal(9)] [RED("parameters", 3)] public CArrayFixedSize<CArray<CHandle<CMaterialParameter>>> Parameters { get; set; }
		[Ordinal(10)] [RED("techniques")] public CArray<MaterialTechnique> Techniques { get; set; }
		[Ordinal(11)] [RED("samplerStates", 3)] public CArrayFixedSize<CArray<SamplerStateInfo>> SamplerStates { get; set; }
		[Ordinal(12)] [RED("usedParameters", 3)] public CArrayFixedSize<CArray<MaterialUsedParameter>> UsedParameters { get; set; }
		[Ordinal(13)] [RED("materialPriority")] public CEnum<EMaterialPriority> MaterialPriority { get; set; }
		[Ordinal(14)] [RED("materialType")] public CEnum<ERenderMaterialType> MaterialType { get; set; }
		[Ordinal(15)] [RED("audioTag")] public CName AudioTag { get; set; }
		[Ordinal(16)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }

		public CMaterialTemplate_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
