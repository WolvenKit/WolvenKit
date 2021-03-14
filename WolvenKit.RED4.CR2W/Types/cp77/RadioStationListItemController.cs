using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioStationListItemController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _typeIcon;
		private CHandle<RadioListItemData> _stationData;

		[Ordinal(15)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("typeIcon")] 
		public inkImageWidgetReference TypeIcon
		{
			get
			{
				if (_typeIcon == null)
				{
					_typeIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "typeIcon", cr2w, this);
				}
				return _typeIcon;
			}
			set
			{
				if (_typeIcon == value)
				{
					return;
				}
				_typeIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("stationData")] 
		public CHandle<RadioListItemData> StationData
		{
			get
			{
				if (_stationData == null)
				{
					_stationData = (CHandle<RadioListItemData>) CR2WTypeManager.Create("handle:RadioListItemData", "stationData", cr2w, this);
				}
				return _stationData;
			}
			set
			{
				if (_stationData == value)
				{
					return;
				}
				_stationData = value;
				PropertySet(this);
			}
		}

		public RadioStationListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
