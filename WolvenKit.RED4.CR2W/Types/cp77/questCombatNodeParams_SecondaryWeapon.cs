using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_SecondaryWeapon : questCombatNodeParams
	{
		private CBool _unEquip;

		[Ordinal(0)] 
		[RED("unEquip")] 
		public CBool UnEquip
		{
			get => GetProperty(ref _unEquip);
			set => SetProperty(ref _unEquip, value);
		}

		public questCombatNodeParams_SecondaryWeapon(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
