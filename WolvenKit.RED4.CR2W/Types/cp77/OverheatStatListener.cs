using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OverheatStatListener : gameScriptStatPoolsListener
	{
		private wCHandle<gameweaponObject> _weapon;
		private CHandle<UpdateOverheatEvent> _updateEvt;
		private CHandle<StartOverheatEffectEvent> _startEvt;

		[Ordinal(0)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(1)] 
		[RED("updateEvt")] 
		public CHandle<UpdateOverheatEvent> UpdateEvt
		{
			get => GetProperty(ref _updateEvt);
			set => SetProperty(ref _updateEvt, value);
		}

		[Ordinal(2)] 
		[RED("startEvt")] 
		public CHandle<StartOverheatEffectEvent> StartEvt
		{
			get => GetProperty(ref _startEvt);
			set => SetProperty(ref _startEvt, value);
		}

		public OverheatStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
