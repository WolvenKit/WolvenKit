using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workEquipInventoryWeaponAction : workIWorkspotItemAction
	{
		private CEnum<workWeaponType> _weaponType;
		private CBool _keepEquippedAfterExit;
		private TweakDBID _fallbackItem;
		private TweakDBID _fallbackSlot;

		[Ordinal(0)] 
		[RED("weaponType")] 
		public CEnum<workWeaponType> WeaponType
		{
			get
			{
				if (_weaponType == null)
				{
					_weaponType = (CEnum<workWeaponType>) CR2WTypeManager.Create("workWeaponType", "weaponType", cr2w, this);
				}
				return _weaponType;
			}
			set
			{
				if (_weaponType == value)
				{
					return;
				}
				_weaponType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("keepEquippedAfterExit")] 
		public CBool KeepEquippedAfterExit
		{
			get
			{
				if (_keepEquippedAfterExit == null)
				{
					_keepEquippedAfterExit = (CBool) CR2WTypeManager.Create("Bool", "keepEquippedAfterExit", cr2w, this);
				}
				return _keepEquippedAfterExit;
			}
			set
			{
				if (_keepEquippedAfterExit == value)
				{
					return;
				}
				_keepEquippedAfterExit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fallbackItem")] 
		public TweakDBID FallbackItem
		{
			get
			{
				if (_fallbackItem == null)
				{
					_fallbackItem = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "fallbackItem", cr2w, this);
				}
				return _fallbackItem;
			}
			set
			{
				if (_fallbackItem == value)
				{
					return;
				}
				_fallbackItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fallbackSlot")] 
		public TweakDBID FallbackSlot
		{
			get
			{
				if (_fallbackSlot == null)
				{
					_fallbackSlot = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "fallbackSlot", cr2w, this);
				}
				return _fallbackSlot;
			}
			set
			{
				if (_fallbackSlot == value)
				{
					return;
				}
				_fallbackSlot = value;
				PropertySet(this);
			}
		}

		public workEquipInventoryWeaponAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
