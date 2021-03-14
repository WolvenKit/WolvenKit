using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareSlot : BaseButtonView
	{
		private inkImageWidgetReference _iconImageRef;
		private CEnum<gamedataEquipmentArea> _slotEquipArea;
		private CInt32 _numSlots;

		[Ordinal(2)] 
		[RED("IconImageRef")] 
		public inkImageWidgetReference IconImageRef
		{
			get
			{
				if (_iconImageRef == null)
				{
					_iconImageRef = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "IconImageRef", cr2w, this);
				}
				return _iconImageRef;
			}
			set
			{
				if (_iconImageRef == value)
				{
					return;
				}
				_iconImageRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("SlotEquipArea")] 
		public CEnum<gamedataEquipmentArea> SlotEquipArea
		{
			get
			{
				if (_slotEquipArea == null)
				{
					_slotEquipArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "SlotEquipArea", cr2w, this);
				}
				return _slotEquipArea;
			}
			set
			{
				if (_slotEquipArea == value)
				{
					return;
				}
				_slotEquipArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("NumSlots")] 
		public CInt32 NumSlots
		{
			get
			{
				if (_numSlots == null)
				{
					_numSlots = (CInt32) CR2WTypeManager.Create("Int32", "NumSlots", cr2w, this);
				}
				return _numSlots;
			}
			set
			{
				if (_numSlots == value)
				{
					return;
				}
				_numSlots = value;
				PropertySet(this);
			}
		}

		public CyberwareSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
