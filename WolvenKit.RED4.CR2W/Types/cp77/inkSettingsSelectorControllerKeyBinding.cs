using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSettingsSelectorControllerKeyBinding : inkSettingsSelectorController
	{
		private inkRichTextBoxWidgetReference _text;
		private inkWidgetReference _buttonRef;
		private inkWidgetReference _editView;
		private CFloat _editOpacity;

		[Ordinal(15)] 
		[RED("text")] 
		public inkRichTextBoxWidgetReference Text
		{
			get
			{
				if (_text == null)
				{
					_text = (inkRichTextBoxWidgetReference) CR2WTypeManager.Create("inkRichTextBoxWidgetReference", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("buttonRef")] 
		public inkWidgetReference ButtonRef
		{
			get
			{
				if (_buttonRef == null)
				{
					_buttonRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonRef", cr2w, this);
				}
				return _buttonRef;
			}
			set
			{
				if (_buttonRef == value)
				{
					return;
				}
				_buttonRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("editView")] 
		public inkWidgetReference EditView
		{
			get
			{
				if (_editView == null)
				{
					_editView = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "editView", cr2w, this);
				}
				return _editView;
			}
			set
			{
				if (_editView == value)
				{
					return;
				}
				_editView = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("editOpacity")] 
		public CFloat EditOpacity
		{
			get
			{
				if (_editOpacity == null)
				{
					_editOpacity = (CFloat) CR2WTypeManager.Create("Float", "editOpacity", cr2w, this);
				}
				return _editOpacity;
			}
			set
			{
				if (_editOpacity == value)
				{
					return;
				}
				_editOpacity = value;
				PropertySet(this);
			}
		}

		public inkSettingsSelectorControllerKeyBinding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
