using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SVfxInstanceData : CVariable
	{
		[Ordinal(0)] [RED("fx")] public CHandle<gameFxInstance> Fx { get; set; }
		[Ordinal(1)] [RED("id")] public CName Id { get; set; }

		public SVfxInstanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
