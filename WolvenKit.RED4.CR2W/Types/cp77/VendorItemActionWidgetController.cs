using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorItemActionWidgetController : DeviceActionWidgetControllerBase
	{
		private inkTextWidgetReference _priceWidget;
		private inkWidgetReference _priceContainer;
		private inkWidgetReference _moneyStatusContainer;
		private inkWidgetReference _processingStatusContainer;

		[Ordinal(28)] 
		[RED("priceWidget")] 
		public inkTextWidgetReference PriceWidget
		{
			get
			{
				if (_priceWidget == null)
				{
					_priceWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "priceWidget", cr2w, this);
				}
				return _priceWidget;
			}
			set
			{
				if (_priceWidget == value)
				{
					return;
				}
				_priceWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("priceContainer")] 
		public inkWidgetReference PriceContainer
		{
			get
			{
				if (_priceContainer == null)
				{
					_priceContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "priceContainer", cr2w, this);
				}
				return _priceContainer;
			}
			set
			{
				if (_priceContainer == value)
				{
					return;
				}
				_priceContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("moneyStatusContainer")] 
		public inkWidgetReference MoneyStatusContainer
		{
			get
			{
				if (_moneyStatusContainer == null)
				{
					_moneyStatusContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "moneyStatusContainer", cr2w, this);
				}
				return _moneyStatusContainer;
			}
			set
			{
				if (_moneyStatusContainer == value)
				{
					return;
				}
				_moneyStatusContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("processingStatusContainer")] 
		public inkWidgetReference ProcessingStatusContainer
		{
			get
			{
				if (_processingStatusContainer == null)
				{
					_processingStatusContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "processingStatusContainer", cr2w, this);
				}
				return _processingStatusContainer;
			}
			set
			{
				if (_processingStatusContainer == value)
				{
					return;
				}
				_processingStatusContainer = value;
				PropertySet(this);
			}
		}

		public VendorItemActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
