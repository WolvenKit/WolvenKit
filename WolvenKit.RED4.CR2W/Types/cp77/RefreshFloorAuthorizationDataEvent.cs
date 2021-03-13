using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshFloorAuthorizationDataEvent : redEvent
	{
		[Ordinal(0)] [RED("passToEntity")] public CBool PassToEntity { get; set; }

		public RefreshFloorAuthorizationDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
