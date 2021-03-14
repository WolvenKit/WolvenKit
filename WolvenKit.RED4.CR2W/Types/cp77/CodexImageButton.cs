using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexImageButton : CodexListItemController
	{
		private inkImageWidgetReference _image;
		private inkImageWidgetReference _border;
		private inkWidgetReference _translateOnSelect;
		private CFloat _selectTranslationX;

		[Ordinal(19)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get
			{
				if (_image == null)
				{
					_image = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "image", cr2w, this);
				}
				return _image;
			}
			set
			{
				if (_image == value)
				{
					return;
				}
				_image = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("border")] 
		public inkImageWidgetReference Border
		{
			get
			{
				if (_border == null)
				{
					_border = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "border", cr2w, this);
				}
				return _border;
			}
			set
			{
				if (_border == value)
				{
					return;
				}
				_border = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("translateOnSelect")] 
		public inkWidgetReference TranslateOnSelect
		{
			get
			{
				if (_translateOnSelect == null)
				{
					_translateOnSelect = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "translateOnSelect", cr2w, this);
				}
				return _translateOnSelect;
			}
			set
			{
				if (_translateOnSelect == value)
				{
					return;
				}
				_translateOnSelect = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("selectTranslationX")] 
		public CFloat SelectTranslationX
		{
			get
			{
				if (_selectTranslationX == null)
				{
					_selectTranslationX = (CFloat) CR2WTypeManager.Create("Float", "selectTranslationX", cr2w, this);
				}
				return _selectTranslationX;
			}
			set
			{
				if (_selectTranslationX == value)
				{
					return;
				}
				_selectTranslationX = value;
				PropertySet(this);
			}
		}

		public CodexImageButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
