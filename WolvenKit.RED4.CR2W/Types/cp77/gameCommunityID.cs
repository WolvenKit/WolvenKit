using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCommunityID : CVariable
	{
		[Ordinal(0)] [RED("entityId")] public entEntityID EntityId { get; set; }

		public gameCommunityID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
