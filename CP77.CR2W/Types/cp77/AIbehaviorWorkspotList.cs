using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorWorkspotList : IScriptable
	{
		[Ordinal(0)]  [RED("spots")] public CArray<NodeRef> Spots { get; set; }

		public AIbehaviorWorkspotList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
