using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionColorPicker : inkWidgetLogicController
	{
		private inkUniformGridWidgetReference _grid;
		private inkTextWidgetReference _title;
		private wCHandle<gameuiCharacterCustomizationOption> _option;
		private CInt32 _selectedIndex;

		[Ordinal(1)] 
		[RED("grid")] 
		public inkUniformGridWidgetReference Grid
		{
			get
			{
				if (_grid == null)
				{
					_grid = (inkUniformGridWidgetReference) CR2WTypeManager.Create("inkUniformGridWidgetReference", "grid", cr2w, this);
				}
				return _grid;
			}
			set
			{
				if (_grid == value)
				{
					return;
				}
				_grid = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get
			{
				if (_title == null)
				{
					_title = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("option")] 
		public wCHandle<gameuiCharacterCustomizationOption> Option
		{
			get
			{
				if (_option == null)
				{
					_option = (wCHandle<gameuiCharacterCustomizationOption>) CR2WTypeManager.Create("whandle:gameuiCharacterCustomizationOption", "option", cr2w, this);
				}
				return _option;
			}
			set
			{
				if (_option == value)
				{
					return;
				}
				_option = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		public characterCreationBodyMorphOptionColorPicker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
