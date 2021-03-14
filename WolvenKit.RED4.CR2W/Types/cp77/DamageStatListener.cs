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
			get
			{
				if (_weapon == null)
				{
					_weapon = (wCHandle<gameweaponObject>) CR2WTypeManager.Create("whandle:gameweaponObject", "weapon", cr2w, this);
				}
				return _weapon;
			}
			set
			{
				if (_weapon == value)
				{
					return;
				}
				_weapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("updateEvt")] 
		public CHandle<UpdateDamageChangeEvent> UpdateEvt
		{
			get
			{
				if (_updateEvt == null)
				{
					_updateEvt = (CHandle<UpdateDamageChangeEvent>) CR2WTypeManager.Create("handle:UpdateDamageChangeEvent", "updateEvt", cr2w, this);
				}
				return _updateEvt;
			}
			set
			{
				if (_updateEvt == value)
				{
					return;
				}
				_updateEvt = value;
				PropertySet(this);
			}
		}

		public DamageStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
