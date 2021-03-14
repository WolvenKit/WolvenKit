using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialMenuGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _containerRef;
		private inkWidgetReference _highlightRef;
		private CArray<inkWidgetReference> _itemListRef;
		private CHandle<gameIBlackboard> _quickSlotsBoard;
		private CHandle<UI_QuickSlotsDataDef> _quickSlotsDef;
		private CUInt32 _inputAxisCallbackId;

		[Ordinal(9)] 
		[RED("containerRef")] 
		public inkCompoundWidgetReference ContainerRef
		{
			get
			{
				if (_containerRef == null)
				{
					_containerRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "containerRef", cr2w, this);
				}
				return _containerRef;
			}
			set
			{
				if (_containerRef == value)
				{
					return;
				}
				_containerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("highlightRef")] 
		public inkWidgetReference HighlightRef
		{
			get
			{
				if (_highlightRef == null)
				{
					_highlightRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "highlightRef", cr2w, this);
				}
				return _highlightRef;
			}
			set
			{
				if (_highlightRef == value)
				{
					return;
				}
				_highlightRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("itemListRef")] 
		public CArray<inkWidgetReference> ItemListRef
		{
			get
			{
				if (_itemListRef == null)
				{
					_itemListRef = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "itemListRef", cr2w, this);
				}
				return _itemListRef;
			}
			set
			{
				if (_itemListRef == value)
				{
					return;
				}
				_itemListRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("quickSlotsBoard")] 
		public CHandle<gameIBlackboard> QuickSlotsBoard
		{
			get
			{
				if (_quickSlotsBoard == null)
				{
					_quickSlotsBoard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "quickSlotsBoard", cr2w, this);
				}
				return _quickSlotsBoard;
			}
			set
			{
				if (_quickSlotsBoard == value)
				{
					return;
				}
				_quickSlotsBoard = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("quickSlotsDef")] 
		public CHandle<UI_QuickSlotsDataDef> QuickSlotsDef
		{
			get
			{
				if (_quickSlotsDef == null)
				{
					_quickSlotsDef = (CHandle<UI_QuickSlotsDataDef>) CR2WTypeManager.Create("handle:UI_QuickSlotsDataDef", "quickSlotsDef", cr2w, this);
				}
				return _quickSlotsDef;
			}
			set
			{
				if (_quickSlotsDef == value)
				{
					return;
				}
				_quickSlotsDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("inputAxisCallbackId")] 
		public CUInt32 InputAxisCallbackId
		{
			get
			{
				if (_inputAxisCallbackId == null)
				{
					_inputAxisCallbackId = (CUInt32) CR2WTypeManager.Create("Uint32", "inputAxisCallbackId", cr2w, this);
				}
				return _inputAxisCallbackId;
			}
			set
			{
				if (_inputAxisCallbackId == value)
				{
					return;
				}
				_inputAxisCallbackId = value;
				PropertySet(this);
			}
		}

		public RadialMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
