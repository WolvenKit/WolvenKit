using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ImageSwappingController : inkWidgetLogicController
	{
		private CString _imageWidgetPath;
		private CArray<CName> _buttonsPaths;
		private CArray<CString> _buttonsNames;
		private CArray<CString> _buttonsValues;
		private CArray<wCHandle<inkCanvasWidget>> _buttons;

		[Ordinal(1)] 
		[RED("ImageWidgetPath")] 
		public CString ImageWidgetPath
		{
			get
			{
				if (_imageWidgetPath == null)
				{
					_imageWidgetPath = (CString) CR2WTypeManager.Create("String", "ImageWidgetPath", cr2w, this);
				}
				return _imageWidgetPath;
			}
			set
			{
				if (_imageWidgetPath == value)
				{
					return;
				}
				_imageWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ButtonsPaths")] 
		public CArray<CName> ButtonsPaths
		{
			get
			{
				if (_buttonsPaths == null)
				{
					_buttonsPaths = (CArray<CName>) CR2WTypeManager.Create("array:CName", "ButtonsPaths", cr2w, this);
				}
				return _buttonsPaths;
			}
			set
			{
				if (_buttonsPaths == value)
				{
					return;
				}
				_buttonsPaths = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ButtonsNames")] 
		public CArray<CString> ButtonsNames
		{
			get
			{
				if (_buttonsNames == null)
				{
					_buttonsNames = (CArray<CString>) CR2WTypeManager.Create("array:String", "ButtonsNames", cr2w, this);
				}
				return _buttonsNames;
			}
			set
			{
				if (_buttonsNames == value)
				{
					return;
				}
				_buttonsNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ButtonsValues")] 
		public CArray<CString> ButtonsValues
		{
			get
			{
				if (_buttonsValues == null)
				{
					_buttonsValues = (CArray<CString>) CR2WTypeManager.Create("array:String", "ButtonsValues", cr2w, this);
				}
				return _buttonsValues;
			}
			set
			{
				if (_buttonsValues == value)
				{
					return;
				}
				_buttonsValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("Buttons")] 
		public CArray<wCHandle<inkCanvasWidget>> Buttons
		{
			get
			{
				if (_buttons == null)
				{
					_buttons = (CArray<wCHandle<inkCanvasWidget>>) CR2WTypeManager.Create("array:whandle:inkCanvasWidget", "Buttons", cr2w, this);
				}
				return _buttons;
			}
			set
			{
				if (_buttons == value)
				{
					return;
				}
				_buttons = value;
				PropertySet(this);
			}
		}

		public ImageSwappingController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
