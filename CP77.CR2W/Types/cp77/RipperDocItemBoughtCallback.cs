using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RipperDocItemBoughtCallback : gameInventoryScriptCallback
	{
		[Ordinal(0)]  [RED("eventTarget")] public CHandle<RipperDocGameController> EventTarget { get; set; }

		public RipperDocItemBoughtCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
