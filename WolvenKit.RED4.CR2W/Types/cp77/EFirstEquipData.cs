using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EFirstEquipData : CVariable
	{
		private TweakDBID _weaponID;
		private CBool _hasPlayedFirstEquip;

		[Ordinal(0)] 
		[RED("weaponID")] 
		public TweakDBID WeaponID
		{
			get
			{
				if (_weaponID == null)
				{
					_weaponID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "weaponID", cr2w, this);
				}
				return _weaponID;
			}
			set
			{
				if (_weaponID == value)
				{
					return;
				}
				_weaponID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hasPlayedFirstEquip")] 
		public CBool HasPlayedFirstEquip
		{
			get
			{
				if (_hasPlayedFirstEquip == null)
				{
					_hasPlayedFirstEquip = (CBool) CR2WTypeManager.Create("Bool", "hasPlayedFirstEquip", cr2w, this);
				}
				return _hasPlayedFirstEquip;
			}
			set
			{
				if (_hasPlayedFirstEquip == value)
				{
					return;
				}
				_hasPlayedFirstEquip = value;
				PropertySet(this);
			}
		}

		public EFirstEquipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
