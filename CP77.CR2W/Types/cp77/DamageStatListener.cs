using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DamageStatListener : gameScriptStatsListener
	{
		[Ordinal(0)]  [RED("updateEvt")] public CHandle<UpdateDamageChangeEvent> UpdateEvt { get; set; }
		[Ordinal(1)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }

		public DamageStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
