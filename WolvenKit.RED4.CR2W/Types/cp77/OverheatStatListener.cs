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
		public CHandle<UpdateOverheatEvent> UpdateEvt
		{
			get
			{
				if (_updateEvt == null)
				{
					_updateEvt = (CHandle<UpdateOverheatEvent>) CR2WTypeManager.Create("handle:UpdateOverheatEvent", "updateEvt", cr2w, this);
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

		[Ordinal(2)] 
		[RED("startEvt")] 
		public CHandle<StartOverheatEffectEvent> StartEvt
		{
			get
			{
				if (_startEvt == null)
				{
					_startEvt = (CHandle<StartOverheatEffectEvent>) CR2WTypeManager.Create("handle:StartOverheatEffectEvent", "startEvt", cr2w, this);
				}
				return _startEvt;
			}
			set
			{
				if (_startEvt == value)
				{
					return;
				}
				_startEvt = value;
				PropertySet(this);
			}
		}

		public OverheatStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
