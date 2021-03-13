using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocLangId : CVariable
	{
		[Ordinal(0)] [RED("langId")] public CUInt8 LangId { get; set; }

		public scnlocLangId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
