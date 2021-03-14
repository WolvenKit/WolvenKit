using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryCyberwareDisplayController : InventoryItemDisplayController
	{
		private inkWidgetReference _ownedFrame;
		private inkWidgetReference _selectedFrame;
		private inkWidgetReference _amountPanel;
		private inkTextWidgetReference _amount;

		[Ordinal(78)] 
		[RED("ownedFrame")] 
		public inkWidgetReference OwnedFrame
		{
			get
			{
				if (_ownedFrame == null)
				{
					_ownedFrame = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ownedFrame", cr2w, this);
				}
				return _ownedFrame;
			}
			set
			{
				if (_ownedFrame == value)
				{
					return;
				}
				_ownedFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(79)] 
		[RED("selectedFrame")] 
		public inkWidgetReference SelectedFrame
		{
			get
			{
				if (_selectedFrame == null)
				{
					_selectedFrame = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectedFrame", cr2w, this);
				}
				return _selectedFrame;
			}
			set
			{
				if (_selectedFrame == value)
				{
					return;
				}
				_selectedFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(80)] 
		[RED("amountPanel")] 
		public inkWidgetReference AmountPanel
		{
			get
			{
				if (_amountPanel == null)
				{
					_amountPanel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "amountPanel", cr2w, this);
				}
				return _amountPanel;
			}
			set
			{
				if (_amountPanel == value)
				{
					return;
				}
				_amountPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(81)] 
		[RED("amount")] 
		public inkTextWidgetReference Amount
		{
			get
			{
				if (_amount == null)
				{
					_amount = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "amount", cr2w, this);
				}
				return _amount;
			}
			set
			{
				if (_amount == value)
				{
					return;
				}
				_amount = value;
				PropertySet(this);
			}
		}

		public InventoryCyberwareDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
