using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Multilayer_LayerTemplateOverridesLevels : CVariable
	{
		[Ordinal(0)]  [RED("n")] public CName N { get; set; }
		[Ordinal(1)]  [RED("v")] public [2]Float V { get; set; }

		public Multilayer_LayerTemplateOverridesLevels(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
