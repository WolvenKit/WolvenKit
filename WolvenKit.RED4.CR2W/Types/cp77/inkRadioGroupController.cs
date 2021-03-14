using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkRadioGroupController : inkWidgetLogicController
	{
		private CArray<inkWidgetReference> _toggleRefs;
		private CBool _alwaysToggled;
		private CInt32 _selectedIndex;
		private inkRadioGroupChangedCallback _valueChanged;

		[Ordinal(1)] 
		[RED("toggleRefs")] 
		public CArray<inkWidgetReference> ToggleRefs
		{
			get
			{
				if (_toggleRefs == null)
				{
					_toggleRefs = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "toggleRefs", cr2w, this);
				}
				return _toggleRefs;
			}
			set
			{
				if (_toggleRefs == value)
				{
					return;
				}
				_toggleRefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("alwaysToggled")] 
		public CBool AlwaysToggled
		{
			get
			{
				if (_alwaysToggled == null)
				{
					_alwaysToggled = (CBool) CR2WTypeManager.Create("Bool", "alwaysToggled", cr2w, this);
				}
				return _alwaysToggled;
			}
			set
			{
				if (_alwaysToggled == value)
				{
					return;
				}
				_alwaysToggled = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("selectedIndex")] 
		public CInt32 SelectedIndex
		{
			get
			{
				if (_selectedIndex == null)
				{
					_selectedIndex = (CInt32) CR2WTypeManager.Create("Int32", "selectedIndex", cr2w, this);
				}
				return _selectedIndex;
			}
			set
			{
				if (_selectedIndex == value)
				{
					return;
				}
				_selectedIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ValueChanged")] 
		public inkRadioGroupChangedCallback ValueChanged
		{
			get
			{
				if (_valueChanged == null)
				{
					_valueChanged = (inkRadioGroupChangedCallback) CR2WTypeManager.Create("inkRadioGroupChangedCallback", "ValueChanged", cr2w, this);
				}
				return _valueChanged;
			}
			set
			{
				if (_valueChanged == value)
				{
					return;
				}
				_valueChanged = value;
				PropertySet(this);
			}
		}

		public inkRadioGroupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
