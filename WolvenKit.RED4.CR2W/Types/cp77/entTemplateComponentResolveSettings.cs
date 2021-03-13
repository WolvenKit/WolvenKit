using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTemplateComponentResolveSettings : CVariable
	{
		[Ordinal(0)] [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(1)] [RED("nameParam")] public CName NameParam { get; set; }
		[Ordinal(2)] [RED("mode")] public CEnum<entTemplateComponentResolveMode> Mode { get; set; }

		public entTemplateComponentResolveSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
