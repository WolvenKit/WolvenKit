using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterTexture : CMaterialParameter
	{
		[Ordinal(2)] [RED("texture")] public rRef<ITexture> Texture { get; set; }

		public CMaterialParameterTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
