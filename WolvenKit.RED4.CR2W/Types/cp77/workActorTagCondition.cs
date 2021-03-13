using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workActorTagCondition : workIWorkspotCondition
	{
		[Ordinal(2)] [RED("tag")] public CName Tag { get; set; }

		public workActorTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
