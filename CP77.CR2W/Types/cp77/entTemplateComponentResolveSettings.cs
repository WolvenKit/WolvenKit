using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entTemplateComponentResolveSettings : CVariable
	{
		[Ordinal(0)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(1)]  [RED("mode")] public CEnum<entTemplateComponentResolveMode> Mode { get; set; }
		[Ordinal(2)]  [RED("nameParam")] public CName NameParam { get; set; }

		public entTemplateComponentResolveSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
