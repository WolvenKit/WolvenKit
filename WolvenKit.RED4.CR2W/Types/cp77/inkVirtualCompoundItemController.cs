using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVirtualCompoundItemController : inkButtonController
	{
		private inkVirtualCompoundItemControllerCallback _toggledOff;
		private inkVirtualCompoundItemControllerCallback _toggledOn;
		private inkVirtualCompoundItemSelectControllerCallback _selected;
		private inkVirtualCompoundItemControllerCallback _deselected;
		private inkVirtualCompoundItemControllerCallback _added;

		[Ordinal(10)] 
		[RED("ToggledOff")] 
		public inkVirtualCompoundItemControllerCallback ToggledOff
		{
			get
			{
				if (_toggledOff == null)
				{
					_toggledOff = (inkVirtualCompoundItemControllerCallback) CR2WTypeManager.Create("inkVirtualCompoundItemControllerCallback", "ToggledOff", cr2w, this);
				}
				return _toggledOff;
			}
			set
			{
				if (_toggledOff == value)
				{
					return;
				}
				_toggledOff = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("ToggledOn")] 
		public inkVirtualCompoundItemControllerCallback ToggledOn
		{
			get
			{
				if (_toggledOn == null)
				{
					_toggledOn = (inkVirtualCompoundItemControllerCallback) CR2WTypeManager.Create("inkVirtualCompoundItemControllerCallback", "ToggledOn", cr2w, this);
				}
				return _toggledOn;
			}
			set
			{
				if (_toggledOn == value)
				{
					return;
				}
				_toggledOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("Selected")] 
		public inkVirtualCompoundItemSelectControllerCallback Selected_656
		{
			get
			{
				if (_selected == null)
				{
					_selected = (inkVirtualCompoundItemSelectControllerCallback) CR2WTypeManager.Create("inkVirtualCompoundItemSelectControllerCallback", "Selected", cr2w, this);
				}
				return _selected;
			}
			set
			{
				if (_selected == value)
				{
					return;
				}
				_selected = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("Deselected")] 
		public inkVirtualCompoundItemControllerCallback Deselected
		{
			get
			{
				if (_deselected == null)
				{
					_deselected = (inkVirtualCompoundItemControllerCallback) CR2WTypeManager.Create("inkVirtualCompoundItemControllerCallback", "Deselected", cr2w, this);
				}
				return _deselected;
			}
			set
			{
				if (_deselected == value)
				{
					return;
				}
				_deselected = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("Added")] 
		public inkVirtualCompoundItemControllerCallback Added
		{
			get
			{
				if (_added == null)
				{
					_added = (inkVirtualCompoundItemControllerCallback) CR2WTypeManager.Create("inkVirtualCompoundItemControllerCallback", "Added", cr2w, this);
				}
				return _added;
			}
			set
			{
				if (_added == value)
				{
					return;
				}
				_added = value;
				PropertySet(this);
			}
		}

		public inkVirtualCompoundItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
