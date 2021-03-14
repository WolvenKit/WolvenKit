using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsController : inkWidgetLogicController
	{
		private inkWidgetReference _detailsButton;
		private inkCompoundWidgetReference _entryContainer;
		private wCHandle<InventoryStatsEntryController> _healthEntryController;
		private wCHandle<InventoryStatsEntryController> _armorEntryController;
		private wCHandle<InventoryStatsEntryController> _staminaEntryController;

		[Ordinal(1)] 
		[RED("detailsButton")] 
		public inkWidgetReference DetailsButton
		{
			get
			{
				if (_detailsButton == null)
				{
					_detailsButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "detailsButton", cr2w, this);
				}
				return _detailsButton;
			}
			set
			{
				if (_detailsButton == value)
				{
					return;
				}
				_detailsButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entryContainer")] 
		public inkCompoundWidgetReference EntryContainer
		{
			get
			{
				if (_entryContainer == null)
				{
					_entryContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "entryContainer", cr2w, this);
				}
				return _entryContainer;
			}
			set
			{
				if (_entryContainer == value)
				{
					return;
				}
				_entryContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("healthEntryController")] 
		public wCHandle<InventoryStatsEntryController> HealthEntryController
		{
			get
			{
				if (_healthEntryController == null)
				{
					_healthEntryController = (wCHandle<InventoryStatsEntryController>) CR2WTypeManager.Create("whandle:InventoryStatsEntryController", "healthEntryController", cr2w, this);
				}
				return _healthEntryController;
			}
			set
			{
				if (_healthEntryController == value)
				{
					return;
				}
				_healthEntryController = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("armorEntryController")] 
		public wCHandle<InventoryStatsEntryController> ArmorEntryController
		{
			get
			{
				if (_armorEntryController == null)
				{
					_armorEntryController = (wCHandle<InventoryStatsEntryController>) CR2WTypeManager.Create("whandle:InventoryStatsEntryController", "armorEntryController", cr2w, this);
				}
				return _armorEntryController;
			}
			set
			{
				if (_armorEntryController == value)
				{
					return;
				}
				_armorEntryController = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("staminaEntryController")] 
		public wCHandle<InventoryStatsEntryController> StaminaEntryController
		{
			get
			{
				if (_staminaEntryController == null)
				{
					_staminaEntryController = (wCHandle<InventoryStatsEntryController>) CR2WTypeManager.Create("whandle:InventoryStatsEntryController", "staminaEntryController", cr2w, this);
				}
				return _staminaEntryController;
			}
			set
			{
				if (_staminaEntryController == value)
				{
					return;
				}
				_staminaEntryController = value;
				PropertySet(this);
			}
		}

		public InventoryStatsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
