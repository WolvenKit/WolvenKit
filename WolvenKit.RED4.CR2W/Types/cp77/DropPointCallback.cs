using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] [RED("dps")] public wCHandle<DropPointSystem> Dps { get; set; }

		public DropPointCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
