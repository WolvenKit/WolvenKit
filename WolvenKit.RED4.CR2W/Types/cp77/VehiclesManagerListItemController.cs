using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehiclesManagerListItemController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _typeIcon;
		private CHandle<VehicleListItemData> _vehicleData;

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
		[RED("vehicleData")] 
		public CHandle<VehicleListItemData> VehicleData
		{
			get
			{
				if (_vehicleData == null)
				{
					_vehicleData = (CHandle<VehicleListItemData>) CR2WTypeManager.Create("handle:VehicleListItemData", "vehicleData", cr2w, this);
				}
				return _vehicleData;
			}
			set
			{
				if (_vehicleData == value)
				{
					return;
				}
				_vehicleData = value;
				PropertySet(this);
			}
		}

		public VehiclesManagerListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
