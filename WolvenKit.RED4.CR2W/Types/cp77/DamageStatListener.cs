using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageStatListener : gameScriptStatsListener
	{
		private wCHandle<gameweaponObject> _weapon;
		private CHandle<UpdateDamageChangeEvent> _updateEvt;

		[Ordinal(0)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(1)] 
		[RED("updateEvt")] 
		public CHandle<UpdateDamageChangeEvent> UpdateEvt
		{
			get => GetProperty(ref _updateEvt);
			set => SetProperty(ref _updateEvt, value);
		}

		public DamageStatListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
