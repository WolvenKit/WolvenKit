using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ForwardAction : redEvent
	{
		[Ordinal(0)]  [RED("actionToForward")] public CHandle<ScriptableDeviceAction> ActionToForward { get; set; }
		[Ordinal(1)]  [RED("requester")] public gamePersistentID Requester { get; set; }

		public ForwardAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
