using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentWorkspotTag : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("tag")] public CHandle<AIArgumentMapping> Tag { get; set; }

		public CheckCurrentWorkspotTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
