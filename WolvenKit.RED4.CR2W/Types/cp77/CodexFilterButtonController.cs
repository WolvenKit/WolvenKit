using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexFilterButtonController : inkWidgetLogicController
	{
		private inkWidgetReference _root;
		private inkImageWidgetReference _image;
		private CEnum<CodexCategoryType> _category;
		private CBool _toggled;
		private CBool _hovered;

		[Ordinal(1)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get
			{
				if (_root == null)
				{
					_root = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("category")] 
		public CEnum<CodexCategoryType> Category
		{
			get
			{
				if (_category == null)
				{
					_category = (CEnum<CodexCategoryType>) CR2WTypeManager.Create("CodexCategoryType", "category", cr2w, this);
				}
				return _category;
			}
			set
			{
				if (_category == value)
				{
					return;
				}
				_category = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("toggled")] 
		public CBool Toggled
		{
			get
			{
				if (_toggled == null)
				{
					_toggled = (CBool) CR2WTypeManager.Create("Bool", "toggled", cr2w, this);
				}
				return _toggled;
			}
			set
			{
				if (_toggled == value)
				{
					return;
				}
				_toggled = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get
			{
				if (_hovered == null)
				{
					_hovered = (CBool) CR2WTypeManager.Create("Bool", "hovered", cr2w, this);
				}
				return _hovered;
			}
			set
			{
				if (_hovered == value)
				{
					return;
				}
				_hovered = value;
				PropertySet(this);
			}
		}

		public CodexFilterButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
