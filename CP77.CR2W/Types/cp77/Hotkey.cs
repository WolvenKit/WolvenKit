using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Hotkey : IScriptable
	{
		[Ordinal(0)]  [RED("hotkey")] public CEnum<gameEHotkey> Hotkey { get; set; }
		[Ordinal(1)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(2)]  [RED("scope")] public CArray<CEnum<gamedataItemType>> Scope { get; set; }

		public Hotkey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
