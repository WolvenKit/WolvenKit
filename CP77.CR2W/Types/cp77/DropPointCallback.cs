using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DropPointCallback : gameInventoryScriptCallback
	{
		[Ordinal(0)]  [RED("dps")] public wCHandle<DropPointSystem> Dps { get; set; }

		public DropPointCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
