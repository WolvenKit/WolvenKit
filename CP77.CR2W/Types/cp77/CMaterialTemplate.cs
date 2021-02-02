using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CMaterialTemplate : IMaterialDefinition
	{
		[Ordinal(0)]  [RED("parameters", 3)] public CArrayFixedSize<CArray<CHandle<CMaterialParameter>>> Parameters { get; set; }
		[Ordinal(1)]  [RED("usedParameters", 3)] public CArrayFixedSize<CArray<MaterialUsedParameter>> UsedParameters { get; set; }
		[Ordinal(2)]  [RED("samplerStates", 3)] public CArrayFixedSize<CArray<SamplerStateInfo>> SamplerStates { get; set; }
		[Ordinal(3)]  [RED("techniques")] public CArray<MaterialTechnique> Techniques { get; set; }
		[Ordinal(4)]  [RED("audioTag")] public CName AudioTag { get; set; }
		[Ordinal(5)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(6)]  [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }
		[Ordinal(7)]  [RED("materialPriority")] public CEnum<EMaterialPriority> MaterialPriority { get; set; }
		[Ordinal(8)]  [RED("materialType")] public CEnum<ERenderMaterialType> MaterialType { get; set; }

		public CMaterialTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
