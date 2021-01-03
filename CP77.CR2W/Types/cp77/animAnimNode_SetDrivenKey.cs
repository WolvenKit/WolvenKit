using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetDrivenKey : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("inputLink")] public animPoseLink InputLink { get; set; }
		[Ordinal(1)]  [RED("provider")] public CHandle<animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider> Provider { get; set; }

		public animAnimNode_SetDrivenKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
