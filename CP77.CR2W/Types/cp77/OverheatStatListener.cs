using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OverheatStatListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)]  [RED("startEvt")] public CHandle<StartOverheatEffectEvent> StartEvt { get; set; }
		[Ordinal(1)]  [RED("updateEvt")] public CHandle<UpdateOverheatEvent> UpdateEvt { get; set; }
		[Ordinal(2)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }

		public OverheatStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
