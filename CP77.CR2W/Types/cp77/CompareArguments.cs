using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CompareArguments : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("var1")] public CName Var1 { get; set; }
		[Ordinal(1)]  [RED("var2")] public CName Var2 { get; set; }

		public CompareArguments(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
