using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisarmComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("isDisarmingOngoing")] public CBool IsDisarmingOngoing { get; set; }
		[Ordinal(6)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(7)] [RED("requester")] public wCHandle<gameObject> Requester { get; set; }

		public DisarmComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
