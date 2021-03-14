using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGridCell : CVariable
	{
		private CInt32 _rarityValue;
		private CHandle<gamedataMiniGame_Trap_Record> _currentTrap;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("rarityValue")] 
		public CInt32 RarityValue
		{
			get
			{
				if (_rarityValue == null)
				{
					_rarityValue = (CInt32) CR2WTypeManager.Create("Int32", "rarityValue", cr2w, this);
				}
				return _rarityValue;
			}
			set
			{
				if (_rarityValue == value)
				{
					return;
				}
				_rarityValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentTrap")] 
		public CHandle<gamedataMiniGame_Trap_Record> CurrentTrap
		{
			get
			{
				if (_currentTrap == null)
				{
					_currentTrap = (CHandle<gamedataMiniGame_Trap_Record>) CR2WTypeManager.Create("handle:gamedataMiniGame_Trap_Record", "currentTrap", cr2w, this);
				}
				return _currentTrap;
			}
			set
			{
				if (_currentTrap == value)
				{
					return;
				}
				_currentTrap = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		public gameuiGridCell(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
