using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NetworkArea : InteractiveMasterDevice
	{
		[Ordinal(0)]  [RED("area")] public CHandle<gameStaticTriggerAreaComponent> Area { get; set; }

		public NetworkArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
