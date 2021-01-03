using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDelegateAttrRef : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }

		public AIbehaviorDelegateAttrRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
