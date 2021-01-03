using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entAnimGraphResourceContainerEntry : CVariable
	{
		[Ordinal(0)]  [RED("animGraphResource")] public rRef<animAnimGraph> AnimGraphResource { get; set; }
		[Ordinal(1)]  [RED("graphName")] public CName GraphName { get; set; }

		public entAnimGraphResourceContainerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
