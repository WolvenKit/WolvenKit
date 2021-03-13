using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CSkinProfile : CResource
	{
		[Ordinal(1)] [RED("blurSize")] public CFloat BlurSize { get; set; }
		[Ordinal(2)] [RED("diffuse")] public CColor Diffuse { get; set; }
		[Ordinal(3)] [RED("falloff")] public CColor Falloff { get; set; }
		[Ordinal(4)] [RED("roughness0")] public CFloat Roughness0 { get; set; }
		[Ordinal(5)] [RED("roughness1")] public CFloat Roughness1 { get; set; }
		[Ordinal(6)] [RED("lobeMix")] public CFloat LobeMix { get; set; }

		public CSkinProfile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
