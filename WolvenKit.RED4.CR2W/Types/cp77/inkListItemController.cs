using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkListItemController : inkButtonController
	{
		private inkListItemControllerCallback _toggledOff;
		private inkListItemControllerCallback _toggledOn;
		private inkListItemControllerCallback _selected;
		private inkListItemControllerCallback _deselected;
		private inkListItemControllerCallback _addedToList;
		private inkTextWidgetReference _labelPathRef;

		[Ordinal(10)] 
		[RED("ToggledOff")] 
		public inkListItemControllerCallback ToggledOff
		{
			get
			{
				if (_toggledOff == null)
				{
					_toggledOff = (inkListItemControllerCallback) CR2WTypeManager.Create("inkListItemControllerCallback", "ToggledOff", cr2w, this);
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
		public inkListItemControllerCallback ToggledOn
		{
			get
			{
				if (_toggledOn == null)
				{
					_toggledOn = (inkListItemControllerCallback) CR2WTypeManager.Create("inkListItemControllerCallback", "ToggledOn", cr2w, this);
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
		public inkListItemControllerCallback Selected_656
		{
			get
			{
				if (_selected == null)
				{
					_selected = (inkListItemControllerCallback) CR2WTypeManager.Create("inkListItemControllerCallback", "Selected", cr2w, this);
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
		public inkListItemControllerCallback Deselected
		{
			get
			{
				if (_deselected == null)
				{
					_deselected = (inkListItemControllerCallback) CR2WTypeManager.Create("inkListItemControllerCallback", "Deselected", cr2w, this);
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
		[RED("AddedToList")] 
		public inkListItemControllerCallback AddedToList
		{
			get
			{
				if (_addedToList == null)
				{
					_addedToList = (inkListItemControllerCallback) CR2WTypeManager.Create("inkListItemControllerCallback", "AddedToList", cr2w, this);
				}
				return _addedToList;
			}
			set
			{
				if (_addedToList == value)
				{
					return;
				}
				_addedToList = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("labelPathRef")] 
		public inkTextWidgetReference LabelPathRef
		{
			get
			{
				if (_labelPathRef == null)
				{
					_labelPathRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "labelPathRef", cr2w, this);
				}
				return _labelPathRef;
			}
			set
			{
				if (_labelPathRef == value)
				{
					return;
				}
				_labelPathRef = value;
				PropertySet(this);
			}
		}

		public inkListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
