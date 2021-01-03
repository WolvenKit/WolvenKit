using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CMaterialTemplate : IMaterialDefinition
	{
		[Ordinal(0)]  [RED("audioTag")] public CName AudioTag { get; set; }
		[Ordinal(1)]  [RED("materialPriority")] public CEnum<EMaterialPriority> MaterialPriority { get; set; }
		[Ordinal(2)]  [RED("materialType")] public CEnum<ERenderMaterialType> MaterialType { get; set; }
		[Ordinal(3)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(4)]  [RED("parameters")] public [3]array<CHandle<CMaterialParameter>> Parameters { get; set; }
		[Ordinal(5)]  [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }
		[Ordinal(6)]  [RED("samplerStates")] public [3]array<SamplerStateInfo> SamplerStates { get; set; }
		[Ordinal(7)]  [RED("techniques")] public CArray<MaterialTechnique> Techniques { get; set; }
		[Ordinal(8)]  [RED("usedParameters")] public [3]array<MaterialUsedParameter> UsedParameters { get; set; }

		public CMaterialTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
