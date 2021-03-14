using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNpcPuppetReplicatedState : gamePuppetReplicatedState
	{
		private gameWeaponsReplicatedState _weaponStates;

		[Ordinal(12)] 
		[RED("weaponStates")] 
		public gameWeaponsReplicatedState WeaponStates
		{
			get
			{
				if (_weaponStates == null)
				{
					_weaponStates = (gameWeaponsReplicatedState) CR2WTypeManager.Create("gameWeaponsReplicatedState", "weaponStates", cr2w, this);
				}
				return _weaponStates;
			}
			set
			{
				if (_weaponStates == value)
				{
					return;
				}
				_weaponStates = value;
				PropertySet(this);
			}
		}

		public gameNpcPuppetReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
