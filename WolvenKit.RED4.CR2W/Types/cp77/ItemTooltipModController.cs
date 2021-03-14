using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModController : inkWidgetLogicController
	{
		private inkWidgetReference _dotIndicator;
		private inkCompoundWidgetReference _modAbilitiesContainer;
		private CHandle<InventoryItemPartDisplay> _partIndicatorController;

		[Ordinal(1)] 
		[RED("dotIndicator")] 
		public inkWidgetReference DotIndicator
		{
			get
			{
				if (_dotIndicator == null)
				{
					_dotIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "dotIndicator", cr2w, this);
				}
				return _dotIndicator;
			}
			set
			{
				if (_dotIndicator == value)
				{
					return;
				}
				_dotIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("modAbilitiesContainer")] 
		public inkCompoundWidgetReference ModAbilitiesContainer
		{
			get
			{
				if (_modAbilitiesContainer == null)
				{
					_modAbilitiesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "modAbilitiesContainer", cr2w, this);
				}
				return _modAbilitiesContainer;
			}
			set
			{
				if (_modAbilitiesContainer == value)
				{
					return;
				}
				_modAbilitiesContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("partIndicatorController")] 
		public CHandle<InventoryItemPartDisplay> PartIndicatorController
		{
			get
			{
				if (_partIndicatorController == null)
				{
					_partIndicatorController = (CHandle<InventoryItemPartDisplay>) CR2WTypeManager.Create("handle:InventoryItemPartDisplay", "partIndicatorController", cr2w, this);
				}
				return _partIndicatorController;
			}
			set
			{
				if (_partIndicatorController == value)
				{
					return;
				}
				_partIndicatorController = value;
				PropertySet(this);
			}
		}

		public ItemTooltipModController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
