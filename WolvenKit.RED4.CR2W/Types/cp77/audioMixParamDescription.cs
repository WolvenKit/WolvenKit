using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMixParamDescription : CVariable
	{
		[Ordinal(0)] [RED("parameter")] public CName Parameter { get; set; }
		[Ordinal(1)] [RED("defaultValue")] public CFloat DefaultValue { get; set; }

		public audioMixParamDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
