using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipModAttachmentData : MinimalItemTooltipModData
	{
		private CBool _isEmpty;
		private CString _slotName;
		private CName _qualityName;
		private CInt32 _abilitiesSize;
		private CArray<gameInventoryItemAbility> _abilities;

		[Ordinal(0)] 
		[RED("isEmpty")] 
		public CBool IsEmpty
		{
			get
			{
				if (_isEmpty == null)
				{
					_isEmpty = (CBool) CR2WTypeManager.Create("Bool", "isEmpty", cr2w, this);
				}
				return _isEmpty;
			}
			set
			{
				if (_isEmpty == value)
				{
					return;
				}
				_isEmpty = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CString) CR2WTypeManager.Create("String", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("qualityName")] 
		public CName QualityName
		{
			get
			{
				if (_qualityName == null)
				{
					_qualityName = (CName) CR2WTypeManager.Create("CName", "qualityName", cr2w, this);
				}
				return _qualityName;
			}
			set
			{
				if (_qualityName == value)
				{
					return;
				}
				_qualityName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("abilitiesSize")] 
		public CInt32 AbilitiesSize
		{
			get
			{
				if (_abilitiesSize == null)
				{
					_abilitiesSize = (CInt32) CR2WTypeManager.Create("Int32", "abilitiesSize", cr2w, this);
				}
				return _abilitiesSize;
			}
			set
			{
				if (_abilitiesSize == value)
				{
					return;
				}
				_abilitiesSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("abilities")] 
		public CArray<gameInventoryItemAbility> Abilities
		{
			get
			{
				if (_abilities == null)
				{
					_abilities = (CArray<gameInventoryItemAbility>) CR2WTypeManager.Create("array:gameInventoryItemAbility", "abilities", cr2w, this);
				}
				return _abilities;
			}
			set
			{
				if (_abilities == value)
				{
					return;
				}
				_abilities = value;
				PropertySet(this);
			}
		}

		public MinimalItemTooltipModAttachmentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
