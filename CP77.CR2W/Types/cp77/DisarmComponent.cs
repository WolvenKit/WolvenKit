using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DisarmComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("isDisarmingOngoing")] public CBool IsDisarmingOngoing { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)]  [RED("requester")] public wCHandle<gameObject> Requester { get; set; }

		public DisarmComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
