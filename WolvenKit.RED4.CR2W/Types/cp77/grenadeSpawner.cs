using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class grenadeSpawner : gameweaponObject
	{
		private CBool _isCombatGadgetActive;

		[Ordinal(57)] 
		[RED("isCombatGadgetActive")] 
		public CBool IsCombatGadgetActive
		{
			get
			{
				if (_isCombatGadgetActive == null)
				{
					_isCombatGadgetActive = (CBool) CR2WTypeManager.Create("Bool", "isCombatGadgetActive", cr2w, this);
				}
				return _isCombatGadgetActive;
			}
			set
			{
				if (_isCombatGadgetActive == value)
				{
					return;
				}
				_isCombatGadgetActive = value;
				PropertySet(this);
			}
		}

		public grenadeSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
