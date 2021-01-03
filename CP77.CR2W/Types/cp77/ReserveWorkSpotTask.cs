using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ReserveWorkSpotTask : WorkSpotTask
	{
		[Ordinal(0)]  [RED("workspotObject")] public wCHandle<gameObject> WorkspotObject { get; set; }
		[Ordinal(1)]  [RED("workspotRef")] public NodeRef WorkspotRef { get; set; }

		public ReserveWorkSpotTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
