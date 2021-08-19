using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class grenadeSpawner : gameweaponObject
	{
		private CBool _isCombatGadgetActive;

		[Ordinal(62)] 
		[RED("isCombatGadgetActive")] 
		public CBool IsCombatGadgetActive
		{
			get => GetProperty(ref _isCombatGadgetActive);
			set => SetProperty(ref _isCombatGadgetActive, value);
		}

		public grenadeSpawner(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
