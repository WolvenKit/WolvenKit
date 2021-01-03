using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WeaponEquipEvent : redEvent
	{
		[Ordinal(0)]  [RED("animFeature")] public CHandle<AnimFeature_EquipType> AnimFeature { get; set; }
		[Ordinal(1)]  [RED("item")] public wCHandle<gameItemObject> Item { get; set; }

		public WeaponEquipEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
